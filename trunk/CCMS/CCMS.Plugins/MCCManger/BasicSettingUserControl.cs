using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.MCCManger
{
    public partial class BasicSettingUserControl : Utils.BaseUserControl
    {
        public BasicSettingUserControl()
        {
            InitializeComponent();
        }

        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G3", "汽车消费贷款管理", "", 2, "G0");
            this._pluginKey = 6;
            this._order = 1;
            this._pluginName = "基础设置";
        }
        #endregion

        private void tsbExit_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
