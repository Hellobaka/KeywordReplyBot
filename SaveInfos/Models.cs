using Native.Sdk.Cqp.EventArgs;
using PublicInfos;
using SqlSugar;


namespace SaveInfos
{
    public interface IOrderModel
    {
        string GetOrderStr();
        bool Judge(string destStr);
        FunctionResult Progress(CQGroupMessageEventArgs e);
        FunctionResult Progress(CQPrivateMessageEventArgs e);
    }

    [SugarTable("qa")]
    public class OrderModel
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }
        public int priority { get; set; }
        public int type { get; set; }
        public int state { get; set; }
        public string keyword { get; set; }
        public string answer { get; set; }
    }
}

