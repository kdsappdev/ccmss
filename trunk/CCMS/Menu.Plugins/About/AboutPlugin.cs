using System;
using System.Collections.Generic;
using System.Text;
using Menu.Help.Plugins;
using System.Windows.Forms;
namespace Menu.Plugins.Help.About
{
    public class AboutPlugin : BasePlugin
    {
        public AboutPlugin()
        {
            _order = 3;
            _pluginKey = 33;
            _pluginName = "关于";
        }
        public override void init(ToolStripMenuItem tsmiHelp)
        {
            ToolStripMenuItem tsi = new ToolStripMenuItem();
            tsi.Text = PluginName;
            tsi.Click += new EventHandler(tsi_Click);
            tsmiHelp.DropDown.Items.Add(tsi);
        }

        void tsi_Click(object sender, EventArgs e)
        {
            AboutForm rf = new AboutForm();
            rf.ShowDialog();
        }
    }
}
