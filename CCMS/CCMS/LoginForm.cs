using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCMS.Plugin;
using CCMS.Helpers;
namespace CCMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        PermissionHelper ph = PermissionHelper.Instance;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckUsersArg())
            {
                if (!backgroundWorker1.IsBusy)
                {
                    setEnable(false);
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void setEnable(bool flag)
        {
            if (this.InvokeRequired)
            {
                CbSimpleBool s = new CbSimpleBool(setEnable);
                this.Invoke(s, new object[] { flag });
            }
            else
            {
                btnLogin.Enabled = flag;
            }
        }
        #region 用户名，密码检查
        private bool CheckUsersArg()
        {
            bool status = true;
            if (string.IsNullOrEmpty(tbUsersName.Text))
            {
                status = false;
                MessageBox.Show("用户名不能为空", "消息提示");
            }
            if (status && string.IsNullOrEmpty(tbUsersPwd.Text))
            {
                status = false;
                MessageBox.Show("密码不能为空", "消息提示");
            }
            return status;
        }
        #endregion

        #region
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(0);
            ph.Login(tbUsersName.Text.Trim(), tbUsersPwd.Text.Trim());

            if (!ph.IsLogin)
            {
                MessageBox.Show("登录失败", "登录");
            }
            else
            {
                backgroundWorker1.ReportProgress(30);
                ph.GetModuleList();
                backgroundWorker1.ReportProgress(80);
                ph.GetFunctionList();
                backgroundWorker1.ReportProgress(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loginProgress(100, e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            setEnable(true);
        }

        #region 进度条
        private void ShowProgress(int total, int sended)
        {
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = total;
            this.progressBar1.Value = sended;
            this.progressBar1.Refresh();
        }
        void loginProgress(int total, int sended)
        {
            if (this.InvokeRequired)
            {
                object[] args = { total, sended };
                this.Invoke(new CbSimpleInt(this.loginProgress), args);
            }
            else
            {
                this.ShowProgress(total, sended);
                if (total == sended)
                {
                 
                    Close();
                }
            }
        }
        public delegate void CbSimpleInt(int total, int sended);
        public delegate void CbSimpleBool(bool flag);
        #endregion

        #endregion

    }
}
