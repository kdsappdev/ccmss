using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCMS.Helpers;
namespace Menu.Help.Plugins
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {

            tbMac.Text = MachineHelper.GetMacAddress2();
             
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string str = CryptoTextBase.ProcessText(this.tbSqe.Text, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("你输入的序列号不正确，请输入正确的序列号", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    public class RegInfo
    {
        string mac;

        public string Mac
        {
            get { return mac; }
            set { mac = value; }
        }
        bool isUseMac = true;

        public bool IsUseMac
        {
            get { return isUseMac; }
            set { isUseMac = value; }
        }
        bool isUseEndDate = true;

        public bool IsUseEndDate
        {
            get { return isUseEndDate; }
            set { isUseEndDate = value; }
        }
        string endDate;

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
