using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IBusAcceptance
{
    public partial class InsurancePremium : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G8", "保险业务受理", "", 2, "G6");
            this._pluginKey = 26;
            this._order = 4;
            this._pluginName = "保险收费";
        }
        #endregion
        public InsurancePremium()
        {
            InitializeComponent();
        }
    }
}
