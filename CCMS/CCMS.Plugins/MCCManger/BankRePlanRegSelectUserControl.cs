using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.MCCManger
{
    public partial class BankRePlanUpateSelectUserControl : CCMS.Plugin.AbstractPlugin
    {
        public BankRePlanUpateSelectUserControl()
        {
            InitializeComponent();
        }
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G5", "信货放款还款", "", 12, "G3");
            this._pluginKey = 13;
            this._pluginName = "银行还款登记";
        }
        #endregion
    }
}
