using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IBusAcceptance
{
    public partial class DangerousConditionOfRegistration : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G8", "保险业务受理", "", 2, "G6");
            this._pluginKey = 25;
            this._order = 3;
            this._pluginName = "出险登记";
        }
        #endregion
        public DangerousConditionOfRegistration()
        {
            InitializeComponent();
        }
    }
}
