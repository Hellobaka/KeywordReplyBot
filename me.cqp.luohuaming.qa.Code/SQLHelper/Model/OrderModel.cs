using SqlSugar;

namespace me.cqp.luohuaming.qa.Code
{
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
