using System;
using System.Collections.Generic;
using System.Text;
using CCMS.Plugin;
using System.Windows.Forms;
namespace Menu.Help.Plugins
{
    public class BasePlugin : IPlugin
    {
        #region IPlugin 属性
        protected object _tag;
        protected int _order;
        protected int _appOrder;
        protected int _appKey;
        public int AppKey { get { return _appKey; } }
        public virtual int AppOrder
        {
            get { return _appOrder; }

        }
        public int Order
        {
            get { return _order; }
        }
        protected string _appName;

        public virtual string AppName
        {
            get { return _appName; }
        }
        protected IApplication _application = null;
        protected bool _enabled = true;
        protected int _pluginKey = 1;
        protected string _pluginName = "";
        protected string _description = "";
        protected string _version = "1.0.0.0";
        protected string _author = "孔德帅";
        public virtual object PluginTag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
            }
        }
        public virtual IApplication Application
        {
            get
            {
                return _application;
            }
            set
            {
                _application = value;
            }
        }
        public virtual bool PluginEnabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
            }
        }
        public virtual int PluginKey { get { return _pluginKey; } }
        public virtual string PluginName { get { return _pluginName; } }
        public virtual string Description { get { return _description; } }
        public virtual string Version { get { return _version; } }
        public virtual string Author { get { return _author; } }
        #endregion

        #region 方法
        public void OnLoading()
        {
            if (Application != null)
            {
                if (Application.MainMenu != null)
                {
                    MenuStrip ms = Application.MainMenu;
                    ToolStripMenuItem tsmiHelp = null;
                    foreach (ToolStripMenuItem tsmi in ms.Items)
                    {
                        if (tsmi.Text.Equals("帮助(&H)"))
                        {
                            tsmiHelp = tsmi;
                            break;
                        }
                    }
                    if (tsmiHelp == null)
                    {
                        tsmiHelp = new ToolStripMenuItem("帮助(&H)");
                        ms.Items.Add(tsmiHelp);
                    }
                    init(tsmiHelp);
                }
            }
        }
        public virtual void init(ToolStripMenuItem tsmiHelp)
        {

        }
        public virtual void BeforeTerminating()
        {
        }
        #endregion
    }
}
