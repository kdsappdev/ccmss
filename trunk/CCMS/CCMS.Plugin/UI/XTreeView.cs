using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace CCMS.UI
{
	#region oldVersion
	/*
	/// <summary>
	/// IXTreeView 用于增强TreeView控件，比如提供节点右键菜单、节点选中事件等
	/// </summary>
	public interface IXTreeView
	{
		ImageList ImageList{get ;set ;}
		int       ImageIndex{get ; set ;} //FolderImageIndex

		ContextMenu ContextMenu{get ;set ;}
		ContextMenu NodeContextMenu{get ;set ;}			

		BorderStyle BorderStyle{get ;set ;}
		Color BackColor{get ;set ;}
		bool  LabelEdit{get ;set ;}

		TreeNode CurrentNode{get ;}
		TreeNodeCollection Nodes{get ;}

		void ExpandAll() ;

		event TreeViewEventHandler NodeSelected ;
		event CBackTextChanged     NodeTextChanged ;
	}


	/// <summary>
	/// XTreeView 的摘要说明。
	/// </summary>
	public class XTreeView : System.Windows.Forms.UserControl ,IXTreeView
	{
		private System.Windows.Forms.TreeView treeView1;		
		private System.ComponentModel.Container components = null;
		
		private ContextMenu mainMenu  = null ;
		private ContextMenu nodeMenu  = null ;
		private TreeNode    curNode   = null ;
		private string      oldNodeText   = null ;

		public XTreeView()
		{			
			InitializeComponent();
		}

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region 组件设计器生成的代码
		/// <summary> 
		/// 设计器支持所需的方法 - 不要使用代码编辑器 
		/// 修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.BackColor = System.Drawing.Color.Gainsboro;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.ImageIndex = -1;
			this.treeView1.LabelEdit = true;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(368, 264);
			this.treeView1.TabIndex = 0;
			this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
			this.treeView1.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_BeforeLabelEdit);
			// 
			// XTreeView
			// 
			this.Controls.Add(this.treeView1);
			this.Name = "XTreeView";
			this.Size = new System.Drawing.Size(368, 264);
			this.ResumeLayout(false);

		}
		#endregion

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			this.curNode = e.Node ;

			if(this.NodeSelected != null)
			{
				this.NodeSelected(sender ,e) ;
			}
		}

		private void treeView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button != MouseButtons.Right)
			{
				return ;
			}

			Point pt = new Point(e.X ,e.Y) ;

			TreeNode destNode = null ;

			this.GetTargetNode(this.treeView1.Nodes[0] ,pt ,out destNode) ;

			if(destNode != null)
			{
				this.curNode = destNode ;				
				this.treeView1.ContextMenu = this.nodeMenu ;
			}
			else
			{
				this.treeView1.ContextMenu = this.mainMenu ;				
			}            
		}

		private bool GetTargetNode(TreeNode curNode ,Point pt ,out TreeNode destNode)
		{
			destNode = null ;
			if(curNode.Bounds.Contains(pt))
			{
				destNode = curNode ;
				return true ;
			}

			if(curNode.Nodes != null)
			{
				foreach(TreeNode node in curNode.Nodes)
				{
					bool found = this.GetTargetNode(node ,pt ,out destNode) ;
					if(found)
					{
						return true ;
					}
				}
			}

			return false ;
		}

		public event CBackTextChanged NodeTextChanged ;

		public void ExpandAll()
		{
			this.treeView1.ExpandAll() ;
		}

		private void treeView1_BeforeLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
		{
			this.oldNodeText = e.Node.Text ;
		}

		private void treeView1_AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
		{
			if((e.Label == this.oldNodeText) ||(e.Label == null))
			{
				return ;
			}

			if(this.NodeTextChanged != null)
			{
				bool accept = this.NodeTextChanged(e.Node ,this.oldNodeText ,e.Label) ;
				if(! accept)
				{
					e.CancelEdit = true ;
				}
			}
		}


		#region IXTreeView 成员

		public ImageList ImageList
		{
			get
			{
				return this.treeView1.ImageList ;
			}
			set
			{
				this.treeView1.ImageList = value ;
			}
		}

		public int ImageIndex
		{
			get
			{
				return this.treeView1.ImageIndex ;
			}
			set
			{
				this.treeView1.ImageIndex = value ;
			}
		}

		public override ContextMenu ContextMenu
		{
			get
			{
				return this.mainMenu ;

			}
			set
			{
				this.mainMenu = value ;
			}
		}

		public ContextMenu NodeContextMenu
		{
			get
			{
				return this.nodeMenu ;

			}
			set
			{
				this.nodeMenu = value ;
			}
		}

		public TreeNode CurrentNode
		{
			get
			{
				return this.curNode ;
			}			
		}

		public TreeNodeCollection Nodes
		{
			get
			{
				return this.treeView1.Nodes ;
			}
		}

		public event TreeViewEventHandler NodeSelected;		

		public override Color BackColor
		{
			get
			{
				return this.treeView1.BackColor ;
			}
			set
			{
				this.treeView1.BackColor = value ;
			}
		}

		public bool LabelEdit
		{
			get
			{
				return this.treeView1.LabelEdit ;
			}
			set
			{
				this.treeView1.LabelEdit = value ;
			}
		
		}

		public BorderStyle BorderStyle
		{
			get
			{
				return this.treeView1.BorderStyle ;
			}
			set
			{
				this.treeView1.BorderStyle = value ;
			}
		}

		#endregion
	}

	public delegate bool CBackTextChanged(TreeNode targetNode ,string oldText ,string newText) ;//返回值false表示拒绝修改
	*/
	#endregion

	
	/// <summary>
	/// IXTreeView 用于增强TreeView控件，比如提供节点右键菜单、节点选中事件、拖放操作等
	/// </summary>
	public interface IXTreeView
	{
		ImageList ImageList{get ;set ;}
		int       ImageIndex{get ; set ;} 
		int       DragTargetImageIndex{get ;set ;} //当目标节点可接收拖放的源时
        
		ContextMenu ContextMenu{get ;set ;}
		ContextMenu NodeContextMenu{get ;set ;}			

		BorderStyle BorderStyle{get ;set ;}
		Color BackColor{get ;set ;}
		bool  LabelEdit{get ;set ;}
		bool  DragEnabled{get ;set ;} //是否启用拖放

		TreeNode CurrentNode{get ;}
		TreeNodeCollection Nodes{get ;}

		void ExpandAll() ;
		void SetCurNodeEditing() ;

		event TreeViewEventHandler NodeSelected ;
		event CBackTextChanged     NodeTextChanged ;
		event CBackNodeDragDropped NodeDragDropped ;
	}


	/// <summary>
	/// XTreeView 的摘要说明。
	/// </summary>
	public class XTreeView : System.Windows.Forms.UserControl ,IXTreeView
	{
		#region Members
		private System.Windows.Forms.TreeView treeView1;		
		private System.ComponentModel.Container components = null;
		
		private ContextMenu mainMenu  = null ;
		private ContextMenu nodeMenu  = null ;
		private TreeNode    curNode   = null ;
		private string      oldNodeText   = null ;
		
		#region drag
		public event CBackNodeDragDropped NodeDragDropped  ;
		private TreeNode    dragSourceNode = null ;
		private int         dragTargetImageIndex = -1 ;
		private int         oldImageIndex        = 0 ;	
		#endregion
		#endregion

		#region ctor ,Dispose
		public XTreeView()
		{			
			InitializeComponent();
		}

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region 组件设计器生成的代码
		/// <summary> 
		/// 设计器支持所需的方法 - 不要使用代码编辑器 
		/// 修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(272, 264);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // XTreeView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.treeView1);
            this.Name = "XTreeView";
            this.Size = new System.Drawing.Size(272, 264);
            this.ResumeLayout(false);

		}
		#endregion		

		#region treeView1_MouseDown
		private void treeView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }	
		#endregion

		#region DragDrop
		private void treeView1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {

        }

		private void treeView1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {

        }

		private void SetAllNodesPreImage(TreeNode theNode)
		{
			if(theNode == null)
			{
				return ;
			}

			if(theNode.ImageIndex == this.dragTargetImageIndex)
			{
				theNode.ImageIndex = this.oldImageIndex ;
				return ;
			}

			if(theNode.Nodes != null)
			{
				foreach(TreeNode node in theNode.Nodes)
				{
					this.SetAllNodesPreImage(node) ;
				}
			}
		}
		#endregion

		#region GetTargetNode
		private bool GetTargetNode(TreeNode curNode ,Point pt ,out TreeNode destNode)
		{
			destNode = null ;
			if(curNode.Bounds.Contains(pt))
			{
				destNode = curNode ;
				return true ;
			}

			if(curNode.Nodes != null)
			{
				foreach(TreeNode node in curNode.Nodes)
				{
					bool found = this.GetTargetNode(node ,pt ,out destNode) ;
					if(found)
					{
						return true ;
					}
				}
			}

			return false ;
		}
		#endregion

		public event CBackTextChanged NodeTextChanged ;

		public void ExpandAll()
		{
			this.treeView1.ExpandAll() ;			
		}

		public void SetCurNodeEditing()
		{
			if(this.curNode != null)
			{
				this.curNode.BeginEdit() ;
			}
		}

		#region eventHanlder
		private void treeView1_BeforeLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
		{
			this.oldNodeText = e.Node.Text ;
        }

		private void treeView1_AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
        {

        }
		#endregion			

		#region IXTreeView 成员

		public ImageList ImageList
		{
			get
			{
				return this.treeView1.ImageList ;
			}
			set
			{
				this.treeView1.ImageList = value ;
			}
		}

		public int ImageIndex
		{
			get
			{
				return this.treeView1.ImageIndex ;
			}
			set
			{
				this.treeView1.ImageIndex = value ;
			}
		}

		public int DragTargetImageIndex
		{
			get
			{
				return this.dragTargetImageIndex ;
			}
			set
			{
				this.dragTargetImageIndex = value ;
			}
		}

		public override ContextMenu ContextMenu
		{
			get
			{
				return this.mainMenu ;

			}
			set
			{
				this.mainMenu = value ;
			}
		}

		public ContextMenu NodeContextMenu
		{
			get
			{
				return this.nodeMenu ;

			}
			set
			{
				this.nodeMenu = value ;
			}
		}

		public TreeNode CurrentNode
		{
			get
			{
				return this.curNode ;
			}			
		}

		public TreeNodeCollection Nodes
		{
			get
			{
				return this.treeView1.Nodes ;
			}
		}

		public event TreeViewEventHandler NodeSelected;		

		public override Color BackColor
		{
			get
			{
				return this.treeView1.BackColor ;
			}
			set
			{
				this.treeView1.BackColor = value ;
			}
		}

		public bool LabelEdit
		{
			get
			{
				return this.treeView1.LabelEdit ;
			}
			set
			{
				this.treeView1.LabelEdit = value ;
			}
		
		}

		public new BorderStyle BorderStyle
		{
			get
			{
				return this.treeView1.BorderStyle ;
			}
			set
			{
				this.treeView1.BorderStyle = value ;
			}
		}

		public bool  DragEnabled
		{
			get
			{
				return this.treeView1.AllowDrop ;
			}
			set
			{
				this.treeView1.AllowDrop = value ;
			}
		}

		#endregion

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            this.curNode = treeView1.SelectedNode;
            this.curNode.Checked = true;          
            TreeViewEventArgs tve = new TreeViewEventArgs(curNode);
            if (this.NodeSelected != null)
            {
                this.NodeSelected(sender, tve);
            }
        }
	}

	public delegate bool CBackTextChanged(TreeNode targetNode ,string oldText ,string newText) ;//返回值false表示拒绝修改
	public delegate void CBackNodeDragDropped(TreeNode sourceNode ,TreeNode targetParentNode ,bool isCopy) ;
}
