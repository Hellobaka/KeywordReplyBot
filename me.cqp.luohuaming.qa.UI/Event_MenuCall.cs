using System;
using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;

namespace me.cqp.luohuaming.qa.UI
{
    public class Event_MenuCall : IMenuCall
    {
        [STAThread]
        public void MenuCall(object sender, CQMenuCallEventArgs e)
        {
            MainForm fm = new MainForm();
            fm.Show();
        }
    }
}
