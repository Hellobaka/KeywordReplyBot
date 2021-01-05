using System.Collections.Generic;
using Native.Sdk.Cqp;

namespace SaveInfos
{
    public static class MainSave
    {
        public static CQLog CQLog { get; set; }
        public static CQApi CQApi { get; set; }
        public static string AppDirectory { get; set; }
        /// <summary>
        /// 保存各种事件的数组
        /// </summary>
        public static List<IOrderModel> Instances { get; set; } = new List<IOrderModel>();
    }
}
