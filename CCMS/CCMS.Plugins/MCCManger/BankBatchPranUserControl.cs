using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.MCCManger
{
    //银行 批量调息
    public partial class BankBatchPranUserControl : Utils.BaseUserControl
    {
        public BankBatchPranUserControl()
        {
            InitializeComponent();
        }
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G5", "信货放款还款", "", 12, "G3");
            this._pluginKey = 14;
            this._order = 3;
            this._pluginName = "批量调息";
        }
        #endregion
    }
}
