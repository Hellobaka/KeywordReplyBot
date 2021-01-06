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
            if (MainSave.DirectMatch == null || MainSave.LikeMatch == null || MainSave.RegexMatch == null)
            {
                Helper.OrderListInit();
            }
            FunctionResult result = new FunctionResult();
            SendText sendText = new SendText();
            sendText.SendID = e.FromGroup;
            if (MainSave.DirectMatch.Any(x => x.keyword == e.Message.Text && x.state == 0))
            {
                result.SendFlag = true;
                sendText.MsgToSend.Add(GetDirectMatchResult(e.Message.Text));
            }
            else if (MainSave.LikeMatch.Any(x => e.Message.Text.Contains(x.keyword) && x.state == 0))
            {
                result.SendFlag = true;
                sendText.MsgToSend.Add(GetLikeMatchResult(e.Message.Text));
            }
            else if (MainSave.RegexMatch.Any(x => Regex.IsMatch(e.Message.Text, x.keyword) && x.state == 0))
            {
                result.SendFlag = true;
                sendText.MsgToSend.Add(GetRegexMatchResult(e.Message.Text));
            }
            result.SendObject.Add(sendText);
            return result;
        }
        string GetDirectMatchResult(string str)
        {
            var ls = MainSave.DirectMatch.Where(x => x.keyword == str && x.state == 0);
            return ls.OrderBy(x => Guid.NewGuid().ToString()).ThenBy(x => x.priority).FirstOrDefault().answer;
        }
        string GetLikeMatchResult(string str)
        {
            var ls = MainSave.LikeMatch.Where(x => str.Contains(x.keyword) && x.state == 0);
            return ls.OrderBy(x => Guid.NewGuid().ToString()).ThenBy(x => x.priority).FirstOrDefault().answer;
        }
        string GetRegexMatchResult(string str)
        {
            var ls = MainSave.RegexMatch.Where(x => Regex.IsMatch(str, x.keyword) && x.state == 0);
            var targetRegex = ls.OrderBy(x => Guid.NewGuid().ToString()).ThenBy(x => x.priority).FirstOrDefault();
            return Regex.Replace(str, targetRegex.keyword, targetRegex.answer);
        }
        public FunctionResult Progress(CQPrivateMessageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
