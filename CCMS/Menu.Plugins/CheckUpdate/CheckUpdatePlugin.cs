using System;
using System.Collections.Generic;
using System.Text;
using Menu.Help.Plugins;
using System.Windows.Forms;
namespace Menu.Help.Plugins.CheckUpdate
{
    public class CheckUpdatePlugin : BasePlugin
    {
        public CheckUpdatePlugin()
        {
            _order = 2;
            _pluginKey = 32;
            _pluginName = "检查更新(&K)";
        }
        public override void init(ToolStripMenuItem tsmiHelp)
        {
            ToolStripMenuItem tsi = new ToolStripMenuItem();
            tsi.Text = PluginName;
            tsi.Click += new EventHandler(tsi_Click);
            tsmiHelp.DropDown.Items.Add(tsi);
        }

      public  void tsi_Click(object sender, EventArgs e)
        {
            #region check and download new version program
            bool bHasError = false;            

            IAutoUpdater autoUpdater = new AutoUpdater();
            try
            {
                autoUpdater.Update(false);
            }

            catch (Exception exp)
            {
                bHasError = true;
                MessageBox.Show("更新失败:"+exp.Message+"","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally
            {
                if (bHasError == true)
                {
                    try
                    {
                        autoUpdater.RollBack();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            #endregion
        }
    }
}
