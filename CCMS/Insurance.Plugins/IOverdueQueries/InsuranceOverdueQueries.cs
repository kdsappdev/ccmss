using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IOverdueQueries
{
    public partial class InsuranceOverdueQueries : Utils.BaseUserControl
    {
    
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G13", "保险逾期查询", "", 6, "G6");
            this._pluginKey = 43;
            this._order = 0;
            this._pluginName = "保险逾期查询";
        }
        #endregion

        public InsuranceOverdueQueries()
        {
            InitializeComponent();
        }
    }
}
