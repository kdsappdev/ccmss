using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.MCCManger
{
    public partial class PayRegUserControl : CCMS.Plugin.AbstractPlugin
    {
        public PayRegUserControl()
        {
            InitializeComponent();
        }
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G3", "汽车消费贷款管理", "", 2, "G0");
            this._pluginKey = 11;
            this._pluginName = "交款登记";
        }
        #endregion

        private void tsbExit_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
