using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.ICustomerManagement
{
    public partial class CustomerDataModification : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G7", "保险客户管理", "", 1, "G6");
            this._pluginKey = 22;
            this._order = 2;
            this._pluginName = "客户资料修改";
        }
        #endregion

        public CustomerDataModification()
        {
            InitializeComponent();
        }
    }
}
