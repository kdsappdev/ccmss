using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IStatisticalInquiry
{
    public partial class InsurancePremium : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G11", "信息统计查询", "", 5, "G6");
            this._pluginKey = 42;
            this._order = 6;
            this._pluginName = "保险收费";
        }
        #endregion
        public InsurancePremium()
        {
            InitializeComponent();
        }
    }
}
