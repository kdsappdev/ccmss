using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.ICustomerManagement
{
    public partial class OwnersChange : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G7", "保险客户管理", "", 1, "G6");
            this._pluginKey = 44;
            this._order = 3;
            this._pluginName = "车主变更";
        }
        #endregion
        public OwnersChange()
        {
            InitializeComponent();
        }
    }
}
