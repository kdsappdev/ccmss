using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IPayment
{
    public partial class PaymentOfInsuranceCompanies : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G9", "保险缴费", "", 3, "G6");
            this._pluginKey = 28;
            this._order = 1;
            this._pluginName = "缴保险公司";
        }
        #endregion
        public PaymentOfInsuranceCompanies()
        {
            InitializeComponent();
        }
    }
}
