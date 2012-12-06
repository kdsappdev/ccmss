using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Insurance.Plugins.IInstallments
{
    public partial class DataEntry : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G10", "保险分期付款", "", 4, "G6");
            this._pluginKey = 30;
            this._order = 1;
            this._pluginName = "资料录入";
        }
        #endregion
        public DataEntry()
        {
            InitializeComponent();
        }



    }
}
