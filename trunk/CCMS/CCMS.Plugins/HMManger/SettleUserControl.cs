using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.HMManger
{
    public partial class SettleUserControl :  CCMS.Plugin.AbstractPlugin
    {
        public SettleUserControl()
        {
            InitializeComponent();
        }

        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G1", "住房按揭管理", "",0, "G0");
            this._pluginKey = 3;
            this._pluginName = "结算信息";
        }
        #endregion

        private void tsbExit_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
