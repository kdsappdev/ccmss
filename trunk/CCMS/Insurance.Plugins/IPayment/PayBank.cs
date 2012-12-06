using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IPayment
{
    public partial class PayBank : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G9", "保险缴费", "", 3, "G6");
            this._pluginKey = 29;
            this._order = 2;
            this._pluginName = "缴银行";
        }
        #endregion
        public PayBank()
        {
            InitializeComponent();
        }
    }
}
