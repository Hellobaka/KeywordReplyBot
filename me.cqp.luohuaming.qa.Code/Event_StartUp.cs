using System.IO;
using me.cqp.luohuaming.qa.Code.OrderFunction;
using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using SaveInfos;

namespace me.cqp.luohuaming.qa.Code
{
    public class Event_StartUp : ICQStartup
    {
        public void CQStartup(object sender, CQStartupEventArgs e)
        {
            MainSave.Instances.Add(new AnswerKeyword());
            MainSave.CQApi = e.CQApi;
            MainSave.CQLog = e.CQLog;
            MainSave.AppDirectory = e.CQApi.AppDirectory;
            SQLHelper.Init(Path.Combine(MainSave.AppDirectory, "qav2.db"));
        }
    }
}
