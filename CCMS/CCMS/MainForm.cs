using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCMS.Plugin;
namespace CCMS
{
    public partial class MainForm : Form, IApplication
    {
        #region IApplication
        public CCMS.Plugin.IPluginManager pluginManager = null;
        public ToolStrip ToolMenu { get { return this.toolStrip1; } }
        public CCMS.Plugin.IPluginManager PluginManager { get { return pluginManager; } }
        public MenuStrip MainMenu { get { return this.menuStrip1; } }
        public StatusStrip StatusBar { get { return this.StatusBar; } }
        public TreeView TreeViemModule { get { return null; } }
        public TabControl TabControl { get { return this.tabControl1; } }
        #endregion

        public MainForm()
        {
            InitializeComponent();            
        }
        private void init()
        {
            this.notifyIcon1.Text = this.Text;
            this.notifyIcon1.Icon = this.Icon;
            pluginManager = new Plugin.PluginManager(this);
            pluginManager.LoadDefault(PluginHelper.PluginSign1);
            addinTreeView2.AddinManagement = pluginManager;    
        }

       


        #region 主窗口关闭，任务栏
        private void tsbExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("你确定退出!", this.Text, MessageBoxButtons.OK | MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
