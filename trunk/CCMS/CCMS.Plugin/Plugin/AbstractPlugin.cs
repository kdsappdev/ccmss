using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
 
namespace CCMS.Plugin
{
    public  class AbstractPlugin : UserControl,IPlugin
    {
        #region IPlugin ÊôÐÔ
        protected object _tag;
        protected IApplication _application = null;
        protected bool _enabled = true;
        protected int _pluginKey = 1;
        protected string _pluginName = "";
        protected string _description = "";
        protected string _version = "1.0.0.0";
        protected string _author = "¿×µÂË§";
        public object PluginTag
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
        public IApplication Application
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
        public bool PluginEnabled
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

        #region
        public virtual void OnLoading()
        {          
        }
        public virtual void BeforeTerminating()
        {          
        }
        #endregion

        #region
        public AbstractPlugin()
        {
            init();
        }
        protected virtual void init()
        { }
        
        protected void exit()
        {

            if (Application != null)
            {
                if (Application.TabControl != null)
                {
                    TabPage t=null;
                    foreach (TabPage tp in Application.TabControl.TabPages)
                    {
                        if (tp.Controls.Contains(this))
                        {
                            t = tp;
                        }
                    }
                    if (t != null)
                    {
                        Application.TabControl.TabPages.Remove(t);
                    }
                }
            }
        }
        #endregion
    }
}
