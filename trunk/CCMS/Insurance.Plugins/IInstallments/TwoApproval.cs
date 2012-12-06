using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IInstallments
{
    public partial class TwoApproval : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G10", "保险分期付款", "", 4, "G6");
            this._pluginKey = 32;
            this._order = 3;
            this._pluginName = "二级审批";
        }
        #endregion
        public TwoApproval()
        {
            InitializeComponent();
        }
    }
}
