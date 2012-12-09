using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Membership.Plugins.CardRetroactiveManagement
{

    public partial class CardRetroactiveManagement : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {

            this._pluginKey = 51;
            this._order = 6;
            this._pluginName = "卡片补办管理";
        }
        #endregion
        public CardRetroactiveManagement()
        {
            InitializeComponent();
        }
    }
}
