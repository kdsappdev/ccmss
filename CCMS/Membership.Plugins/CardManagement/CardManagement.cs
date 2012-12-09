using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Membership.Plugins.CardManagement
{
    public partial class CardManagement : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {

            this._pluginKey = 46;
            this._order = 2;
            this._pluginName = "发卡管理";
        }
        #endregion
        public CardManagement()
        {
            InitializeComponent();
        }
    }
}
