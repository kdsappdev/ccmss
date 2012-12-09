using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Membership.Plugins.AuthorizedBooks
{
    public partial class AuthorizedBooks :Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            
            this._pluginKey = 47;
            this._order = 1;
            this._pluginName = "用户授权";
        }
        #endregion
        public AuthorizedBooks()
        {
            InitializeComponent();
        }
    }
}
