using System.Linq;

namespace SaveInfos
{
    public static class Helper
    {
        public static void OrderListInit()
        {
            MainSave.DirectMatch = MainSave.OrderModels.Where(x => x.type == 0).ToList();
            MainSave.DirectMatch.ForEach(x => x.keyword = x.keyword.Replace("\0", ""));
            MainSave.LikeMatch = MainSave.OrderModels.Where(x => x.type == 1).ToList();
            MainSave.LikeMatch.ForEach(x => x.keyword = x.keyword.Replace("\0", ""));
            MainSave.RegexMatch = MainSave.OrderModels.Where(x => x.type == 2).ToList();
            MainSave.RegexMatch.ForEach(x => x.keyword = x.keyword.Replace("\0", ""));
        }
    }
}
