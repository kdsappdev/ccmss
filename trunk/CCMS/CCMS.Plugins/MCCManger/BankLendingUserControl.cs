using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.MCCManger
{
    public partial class BankLendingUserControl : Utils.BaseUserControl
    {
        public BankLendingUserControl()
        {
            InitializeComponent();
        }
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G5", "信货放款还款", "", 12, "G3");
            this._pluginKey = 12;
            this._order = 1;
            this._pluginName = "银行放贷";
        }
        #endregion

        private void tsbExit_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
