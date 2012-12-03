using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugins.HMManger
{
    public partial class CustomerRegAndSelectUserControl : Utils.BaseUserControl
    {
        #region Plugin
        protected override void init()
        {
            this._tag = new CCMS.UI.Module("G1","住房按揭管理","",0,"G0");           
            this._pluginKey = 1;
            this._order = 1;
            this._pluginName = "客户登记/查询"; 
        }     
        
        #endregion

        public CustomerRegAndSelectUserControl()
        {
            InitializeComponent();                    
        }

        #region 退出
        private void tsbExit_Click(object sender, EventArgs e)
        {
            exit();
        }
        #endregion
    }
}
