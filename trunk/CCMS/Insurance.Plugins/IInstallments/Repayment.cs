using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IInstallments
{
    public partial class Repayment : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G10", "保险分期付款", "", 4, "G6");
            this._pluginKey = 34;
            this._order = 5;
            this._pluginName = "还款";
        }
        #endregion
        public Repayment()
        {
            InitializeComponent();
        }
    }
}
