using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Membership.Plugins.SystemMaintenance
{
    public partial class SystemMaintenance : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {

            this._pluginKey = 53;
            this._order = 8;
            this._pluginName = "系统维护";
        }
        #endregion
        public SystemMaintenance()
        {
            InitializeComponent();
        }
    }
}
