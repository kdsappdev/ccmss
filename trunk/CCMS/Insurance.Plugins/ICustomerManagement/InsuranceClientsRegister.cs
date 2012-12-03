using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.ICustomerManagement
{
    public partial class InsuranceClientsRegister : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G7", "保险客户管理", "", 1, "G6");
            this._pluginKey = 21;
            this._order = 1;
            this._pluginName = "保险客户登记";
        }
        #endregion

        public InsuranceClientsRegister()
        {
            InitializeComponent();
        }
    }
}
