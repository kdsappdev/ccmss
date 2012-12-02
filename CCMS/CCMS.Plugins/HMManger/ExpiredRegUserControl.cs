using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.HMManger
{
    public partial class ExpiredRegUserControl :  CCMS.Plugin.AbstractPlugin
    {
        public ExpiredRegUserControl()
        {
            InitializeComponent();
            cbDate.SelectedIndex = 0;
        }
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G2", "逾期情况", "", 4, "G1");
            this._pluginKey = 4;
            this._pluginName = "逾期录入";
        }
        #endregion
    }
}
