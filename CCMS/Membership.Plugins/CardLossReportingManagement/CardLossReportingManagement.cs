using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Membership.Plugins.CardLossReportingManagement
{
    public partial class CardLossReportingManagement : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {

            this._pluginKey = 50;
            this._order = 5;
            this._pluginName = "卡片挂失管理";
        }
        #endregion
        public CardLossReportingManagement()
        {
            InitializeComponent();
        }
    }
}
