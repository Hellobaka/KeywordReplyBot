using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using SaveInfos;

namespace me.cqp.luohuaming.qa.Code
{
    public class Event_StartUp : ICQStartup
    {
        public void CQStartup(object sender, CQStartupEventArgs e)
        {
            //MainSave.Instances.Add(new xxx());
            MainSave.CQApi = e.CQApi;
            MainSave.CQLog = e.CQLog;
        }
    }
}
