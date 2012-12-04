using System;
using System.Collections.Generic;
using System.Text;
using Menu.Help.Plugins;
using System.Windows.Forms;
namespace Menu.Plugins.Help.Reg
{
    public class RegPlugin : BasePlugin
    {
        public RegPlugin()
        {
            _order = 1;
            _pluginKey = 31;
            _pluginName = "注册产品(&R)";
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
            RegForm rf = new RegForm();
            rf.ShowDialog();
        }
    }
}
