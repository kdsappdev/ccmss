using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IBusAcceptance
{
    public partial class InsuranceRenewalLevel : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G8", "保险业务受理", "", 1, "G6");
            this._pluginKey = 23;
            this._order = 1;
            this._pluginName = "保险续保登记";
        }
        #endregion

        public InsuranceRenewalLevel()
        {
            InitializeComponent();
        }
    }
}
