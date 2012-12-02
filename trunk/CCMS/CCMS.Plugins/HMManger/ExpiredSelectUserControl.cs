using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.HMManger
{
    public partial class ExpiredSelectUserControl : CCMS.Plugin.AbstractPlugin
    {
        public ExpiredSelectUserControl()
        {
            InitializeComponent();
        }
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G2", "逾期情况", "", 4, "G1");
            this._pluginKey = 5;
            this._pluginName = "逾期查询";
        }
        #endregion
    }
}
