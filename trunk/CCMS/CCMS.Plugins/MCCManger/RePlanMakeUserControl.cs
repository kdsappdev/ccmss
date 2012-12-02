using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.MCCManger
{
    public partial class RePlanMakeUserControl : CCMS.Plugin.AbstractPlugin
    {
        public RePlanMakeUserControl()
        {
            InitializeComponent();
        }
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G4", "还款计划管理", "", 8, "G3");
            this._pluginKey = 8;
            this._pluginName = "还款计划制作";
        }
        #endregion

        private void tsbExit_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
