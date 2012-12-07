namespace CCMS
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbUsersPwd = new System.Windows.Forms.Label();
            this.tbUsersName = new System.Windows.Forms.TextBox();
            this.tbUsersPwd = new System.Windows.Forms.TextBox();
            this.lbUsersName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLogin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Controls.Add(this.lbUsersPwd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbUsersName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbUsersPwd, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbUsersName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbUsersPwd
            // 
            this.lbUsersPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsersPwd.Location = new System.Drawing.Point(10, 58);
            this.lbUsersPwd.Name = "lbUsersPwd";
            this.lbUsersPwd.Size = new System.Drawing.Size(61, 36);
            this.lbUsersPwd.TabIndex = 3;
            this.lbUsersPwd.Text = "密 码：";
            this.lbUsersPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUsersName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbUsersName, 3);
            this.tbUsersName.Location = new System.Drawing.Point(77, 32);
            this.tbUsersName.MaxLength = 10;
            this.tbUsersName.Name = "tbUsersName";
            this.tbUsersName.Size = new System.Drawing.Size(188, 21);
            this.tbUsersName.TabIndex = 0;
            this.tbUsersName.Text = "wangchao";
            // 
            // tbUsersPwd
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbUsersPwd, 3);
            this.tbUsersPwd.Location = new System.Drawing.Point(77, 61);
            this.tbUsersPwd.MaxLength = 10;
            this.tbUsersPwd.Name = "tbUsersPwd";
            this.tbUsersPwd.PasswordChar = '*';
            this.tbUsersPwd.Size = new System.Drawing.Size(188, 21);
            this.tbUsersPwd.TabIndex = 1;
            this.tbUsersPwd.Text = "111111";
            // 
            // lbUsersName
            // 
            this.lbUsersName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsersName.Location = new System.Drawing.Point(10, 29);
            this.lbUsersName.Name = "lbUsersName";
            this.lbUsersName.Size = new System.Drawing.Size(61, 29);
            this.lbUsersName.TabIndex = 2;
            this.lbUsersName.Text = "用户名：";
            this.lbUsersName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar1, 5);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(10, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(295, 21);
            this.progressBar1.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(120, 124);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(70, 22);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 150);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbUsersPwd;
        private System.Windows.Forms.TextBox tbUsersName;
        private System.Windows.Forms.TextBox tbUsersPwd;
        private System.Windows.Forms.Label lbUsersName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}