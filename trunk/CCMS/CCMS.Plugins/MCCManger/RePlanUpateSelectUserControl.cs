using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.MCCManger
{
    public partial class RePlanUpateSelectUserControl : Utils.BaseUserControl
    {
        public RePlanUpateSelectUserControl()
        {
            InitializeComponent();
        }
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G4", "还款计划管理", "", 3, "G3");
            this._pluginKey = 9;
            this._pluginName = "还款计划修改/查询";
        }
        #endregion
    }
}
