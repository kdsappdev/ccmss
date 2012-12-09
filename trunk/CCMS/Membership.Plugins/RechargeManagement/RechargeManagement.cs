using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Membership.Plugins.RechargeManagement
{
    public partial class RechargeManagement : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {

            this._pluginKey = 48;
            this._order = 3;
            this._pluginName = "充值管理";
        }
        #endregion
        public RechargeManagement()
        {
            InitializeComponent();
        }



    }
}
