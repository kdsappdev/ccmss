﻿namespace CCMS
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册产品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查新版本CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLock = new System.Windows.Forms.ToolStripButton();
            this.tsbModifyPwd = new System.Windows.Forms.ToolStripButton();
            this.tsbRef = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addinTreeView2 = new CCMS.UI.AddinTreeView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统YToolStripMenuItem,
            this.系统维护ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统YToolStripMenuItem
            // 
            this.系统YToolStripMenuItem.Name = "系统YToolStripMenuItem";
            this.系统YToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统YToolStripMenuItem.Text = "系统(&Y)";
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            this.系统维护ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.系统维护ToolStripMenuItem.Text = "系统维护(&Z)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册产品ToolStripMenuItem,
            this.检查新版本CToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 注册产品ToolStripMenuItem
            // 
            this.注册产品ToolStripMenuItem.Name = "注册产品ToolStripMenuItem";
            this.注册产品ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.注册产品ToolStripMenuItem.Text = "注册产品(&R)";
            // 
            // 检查新版本CToolStripMenuItem
            // 
            this.检查新版本CToolStripMenuItem.Name = "检查新版本CToolStripMenuItem";
            this.检查新版本CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.检查新版本CToolStripMenuItem.Text = "检查新版本(&C)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLock,
            this.tsbModifyPwd,
            this.tsbRef,
            this.toolStripButton4,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(823, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbLock
            // 
            this.tsbLock.Image = ((System.Drawing.Image)(resources.GetObject("tsbLock.Image")));
            this.tsbLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLock.Name = "tsbLock";
            this.tsbLock.Size = new System.Drawing.Size(52, 22);
            this.tsbLock.Text = "锁定";
            // 
            // tsbModifyPwd
            // 
            this.tsbModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsbModifyPwd.Image")));
            this.tsbModifyPwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModifyPwd.Name = "tsbModifyPwd";
            this.tsbModifyPwd.Size = new System.Drawing.Size(76, 22);
            this.tsbModifyPwd.Text = "修改密码";
            // 
            // tsbRef
            // 
            this.tsbRef.Image = ((System.Drawing.Image)(resources.GetObject("tsbRef.Image")));
            this.tsbRef.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRef.Name = "tsbRef";
            this.tsbRef.Size = new System.Drawing.Size(76, 22);
            this.tsbRef.Text = "刷新权限";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton4.Text = "重新连接";
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(52, 22);
            this.tsbExit.Text = "退出";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(823, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "操作员:系统员";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addinTreeView2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(823, 451);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // addinTreeView2
            // 
            this.addinTreeView2.AddinCatalogImageIndex = 0;
            this.addinTreeView2.AddinDisabledImageIndex = 0;
            this.addinTreeView2.AddinEnabledImageIndex = 0;
            this.addinTreeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addinTreeView2.ImageList = null;
            this.addinTreeView2.Location = new System.Drawing.Point(0, 0);
            this.addinTreeView2.Name = "addinTreeView2";
            this.addinTreeView2.RootImageIndex = 0;
            this.addinTreeView2.Size = new System.Drawing.Size(136, 451);
            this.addinTreeView2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 523);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "4S综合管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统YToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbLock;
        private System.Windows.Forms.ToolStripButton tsbModifyPwd;
        private System.Windows.Forms.ToolStripButton tsbRef;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private UI.AddinTreeView addinTreeView1;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查新版本CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册产品ToolStripMenuItem;
        private CCMS.UI.AddinTreeView addinTreeView2;
    }
}

