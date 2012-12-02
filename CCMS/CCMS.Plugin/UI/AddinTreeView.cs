using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using CCMS.Plugin;

namespace CCMS.UI
{
    /// <summary>
    /// FunAddinTreeView 的摘要说明。
    /// </summary>
    public class AddinTreeView : System.Windows.Forms.UserControl, IAddinTreeView
    {
        #region selfMembers
        private System.ComponentModel.IContainer components = null;
        private XTreeView xTreeView1;
        #endregion

        private IPluginManager addinMgr = new PluginManager();

        #region ctor ,Dispose
        public AddinTreeView()
        {
            InitializeComponent();
            xTreeView1.NodeSelected += new TreeViewEventHandler(xTreeView1_NodeSelected);
        }

        void xTreeView1_NodeSelected(object sender, TreeViewEventArgs e)
        {
            TreeNode node = xTreeView1.CurrentNode;
            if (node.Tag != null)
            {
                int tag = -1;
                if (int.TryParse(node.Tag.ToString(), out tag))
                {
                    IPlugin plugin = addinMgr.GetPlugin(tag);
                    if (plugin != null)
                    {
                        TabPage tp = new TabPage(plugin.PluginName);
                        IPlugin p = (IPlugin)Activator.CreateInstance(plugin.GetType());
                        p.Application = plugin.Application;
                        UserControl uc = p as UserControl;
                        if (uc != null)
                        {
                            uc.Dock = DockStyle.Fill;
                            tp.Controls.Add(uc);
                            plugin.Application.TabControl.Controls.Add(tp);
                            plugin.Application.TabControl.SelectedTab = tp;
                        }

                    }
                }
            }
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region property
        #region ImageList
        public ImageList ImageList
        {
            get
            {
                return this.xTreeView1.ImageList;
            }
            set
            {
                this.xTreeView1.ImageList = value;
            }
        }
        #endregion

        #region RootImageIndex
        private int rootImageIndex = 0;
        public int RootImageIndex
        {
            get
            {
                return this.rootImageIndex;
            }
            set
            {
                this.rootImageIndex = value;
            }
        }
        #endregion

        #region AddinEnabledImageIndex
        private int addinEnabledImageIndex = 0;
        public int AddinEnabledImageIndex
        {
            get
            {
                return this.addinEnabledImageIndex;
            }
            set
            {
                this.addinEnabledImageIndex = value;
            }
        }
        #endregion

        #region AddinDisabledImageIndex
        private int addinDisabledImageIndex = 0;
        public int AddinDisabledImageIndex
        {
            get
            {
                return this.addinDisabledImageIndex;
            }
            set
            {
                this.addinDisabledImageIndex = value;
            }
        }
        #endregion

        #region AddinCatalogImageIndex
        private int addinCatalogImageIndex = 0;
        public int AddinCatalogImageIndex
        {
            get
            {
                return this.addinCatalogImageIndex;
            }
            set
            {
                this.addinCatalogImageIndex = value;
            }
        }
        #endregion

        #region IAddinTreeView 成员

        public IPluginManager AddinManagement
        {
            set
            {
                this.addinMgr = value;
                this.addinMgr.PluginChanged += new PluginChanged(addinMgr_PluginChanged);
                addinMgr_PluginChanged();
            }
        }

        void addinMgr_PluginChanged()
        {
            addinMgr_AddinsChanged();
        }

        #endregion

        #endregion

        #region 组件设计器生成的代码
        /// <summary> 
        /// 设计器支持所需的方法 - 不要使用代码编辑器 
        /// 修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.xTreeView1 = new XTreeView();
            this.SuspendLayout();


            // 
            // xTreeView1
            // 
            this.xTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xTreeView1.DragEnabled = false;
            this.xTreeView1.DragTargetImageIndex = -1;
            this.xTreeView1.ImageIndex = -1;
            this.xTreeView1.ImageList = null;
            this.xTreeView1.LabelEdit = false;
            this.xTreeView1.Location = new System.Drawing.Point(0, 0);
            this.xTreeView1.Name = "xTreeView1";
            this.xTreeView1.Size = new System.Drawing.Size(184, 360);
            this.xTreeView1.TabIndex = 0;
            // 
            // AddinTreeView
            // 
            this.Controls.Add(this.xTreeView1);
            this.Name = "AddinTreeView";
            this.Size = new System.Drawing.Size(184, 360);
            this.ResumeLayout(false);

        }
        #endregion

        #region 重新填充整个树
        //重新填充整个树
        private void addinMgr_AddinsChanged()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new CBLoadAddin(this.addinMgr_AddinsChanged), null);
            }
            else
            {
                this.xTreeView1.Nodes.Clear();
                TreeDataSet ds = new TreeDataSet();
                TreeNode root = new TreeNode("已加载的插件", this.rootImageIndex, this.rootImageIndex);
                root.ExpandAll();
                this.xTreeView1.Nodes.Add(root);
                IList<IPlugin> addinList = this.addinMgr.PluginList;
                foreach (IPlugin addin in addinList)
                {
                    Module m = new Module();
                    m.Id = addin.PluginKey.ToString();
                    m.Name = addin.PluginName;
                    m.Order = addin.PluginKey;
                    m.ClassName = addin.GetType().FullName;
                   Module m2= addin.PluginTag as Module;
                   if (m2 != null)
                   {
                       m.ParanetId = m2.Id;
                       m2.ModuleType = "ModuleGroup";

                   }
                   else
                   {
                       m.ParanetId = "G0";
                   }
                   m.Enable = addin.PluginEnabled;
                   m.ModuleType = "Module";
                   ds.Add(m);
                   ds.Add(m2);
                  
                }
                addNodes(root.Nodes, ds.GetDataSet(), "G0");
                xTreeView1.ExpandAll();
            }
        }
        private void addNodes(TreeNodeCollection collection, DataSet treeDataSet, string parentNodeID)
        {
            DataRow[] rows = treeDataSet.Tables[0].Select("paranetId='" + parentNodeID + "'", "MOrder ASC");//查找当前结点的所有子结点 

            foreach (DataRow row in rows)
            {                 
                int imageIndex = row["Enable"].ToString()==bool.TrueString ? this.addinEnabledImageIndex : this.addinDisabledImageIndex;
                string nodeText = string.Format("{0}", row["Name"].ToString());
                TreeNode addinNode = new TreeNode(nodeText, imageIndex, imageIndex);
                addinNode.Tag = row["Id"];              
                collection.Add(addinNode);  
                addNodes(addinNode.Nodes, treeDataSet, row["Id"].ToString());
            }
        } 
        #endregion
    }

    public interface IAddinTreeView
    {
        IPluginManager AddinManagement { set; }
    }

    public delegate void CBAddinStateChanged(int addinKey);
    public delegate void CBLoadAddin();
}
