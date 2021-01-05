using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Native.Sdk.Cqp.EventArgs;
using PublicInfos;
using SaveInfos;

namespace me.cqp.luohuaming.qa.Code.OrderFunction
{
    public class AnswerKeyword : IOrderModel
    {
        static List<OrderModel> orderModels;
        public static List<OrderModel> OrderModels
        {
            get
            {
                if (orderModels == null || orderModels.Count == 0)
                {
                    orderModels = SQLHelper.GetAllOrder();
                }
                return orderModels;
            }
            set { orderModels = value; }
        }
        static List<OrderModel> DirectMatch { get; set; }
        static List<OrderModel> LikeMatch { get; set; }
        static List<OrderModel> RegexMatch { get; set; }

        public string GetOrderStr()
        {
            throw new NotImplementedException();
        }

        public bool Judge(string destStr)
        {
            return true;
        }

        public FunctionResult Progress(CQGroupMessageEventArgs e)
        {
            if (DirectMatch == null || LikeMatch == null || RegexMatch == null)
            {
                OrderListInit();
            }
            FunctionResult result = new FunctionResult();
            SendText sendText = new SendText();
            sendText.SendID = e.FromGroup;
            if (DirectMatch.Any(x => x.keyword == e.Message.Text))
            {
                result.SendFlag = true;
                sendText.MsgToSend.Add(GetDirectMatchResult(e.Message.Text));
            }
            else if (LikeMatch.Any(x => e.Message.Text.Contains(x.keyword)))
            {
                result.SendFlag = true;
                sendText.MsgToSend.Add(GetLikeMatchResult(e.Message.Text));
            }
            else if (RegexMatch.Any(x => Regex.IsMatch(e.Message.Text, x.keyword)))
            {
                result.SendFlag = true;
                sendText.MsgToSend.Add(GetRegexMatchResult(e.Message.Text));
            }
            result.SendObject.Add(sendText);
            return result;
        }
        void OrderListInit()
        {
            DirectMatch = OrderModels.Where(x => x.type == 0).ToList();
            DirectMatch.ForEach(x => x.keyword = x.keyword.Replace("\0", ""));
            LikeMatch = OrderModels.Where(x => x.type == 1).ToList();
            LikeMatch.ForEach(x => x.keyword = x.keyword.Replace("\0", ""));
            RegexMatch = OrderModels.Where(x => x.type == 2).ToList();
            RegexMatch.ForEach(x => x.keyword = x.keyword.Replace("\0", ""));
        }
        string GetDirectMatchResult(string str)
        {
            var ls = DirectMatch.Where(x => x.keyword == str);
            return ls.OrderBy(x => Guid.NewGuid().ToString()).ThenBy(x => x.priority).FirstOrDefault().answer;
        }
        string GetLikeMatchResult(string str)
        {
            var ls = LikeMatch.Where(x => str.Contains(x.keyword));
            return ls.OrderBy(x => Guid.NewGuid().ToString()).ThenBy(x => x.priority).FirstOrDefault().answer;
        }
        string GetRegexMatchResult(string str)
        {
            var ls = RegexMatch.Where(x => Regex.IsMatch(str, x.keyword));
            var targetRegex = ls.OrderBy(x => Guid.NewGuid().ToString()).ThenBy(x => x.priority).FirstOrDefault();
            return Regex.Replace(str, targetRegex.keyword, targetRegex.answer);
        }
        public FunctionResult Progress(CQPrivateMessageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
