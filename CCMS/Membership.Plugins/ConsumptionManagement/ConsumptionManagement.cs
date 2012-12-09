using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Membership.Plugins.ConsumptionManagement
{
    public partial class ConsumptionManagement : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {

            this._pluginKey = 49;
            this._order = 4;
            this._pluginName = "充值管理";
        }
        #endregion
        public ConsumptionManagement()
        {
            InitializeComponent();
        }


    }
}
