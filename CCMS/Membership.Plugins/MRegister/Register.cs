using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Membership.Plugins.MRegister
{
    public partial class Register : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G12", "会员管理", "", 1, "G0");
            this._pluginKey = 46;
            this._order = 1;
            this._pluginName = "注册";
        }
        #endregion
        public Register()
        {
            InitializeComponent();
        }
    }
}
