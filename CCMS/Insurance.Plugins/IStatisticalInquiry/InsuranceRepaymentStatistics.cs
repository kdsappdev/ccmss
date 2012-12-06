using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IStatisticalInquiry
{
    public partial class InsuranceRepaymentStatistics : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G11", "信息统计查询", "", 5, "G6");
            this._pluginKey = 40;
            this._order = 4;
            this._pluginName = "保险还款统计";
        }
        #endregion
        public InsuranceRepaymentStatistics()
        {
            InitializeComponent();
        }
    }
}
