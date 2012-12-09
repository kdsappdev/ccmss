using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Membership.Plugins.QueryManager
{
    public partial class QueryManager : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {

            this._pluginKey = 52;
            this._order = 7;
            this._pluginName = "查询管理";
        }
        #endregion
        public QueryManager()
        {
            InitializeComponent();
        }
    }
}
