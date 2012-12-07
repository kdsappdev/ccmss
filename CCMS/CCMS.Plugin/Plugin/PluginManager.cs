using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CCMS.Helpers;
namespace CCMS.Plugin
{
    /// <summary>
    /// PluginManager
    /// 
    /// �������Ĭ��ʵ��  ���ڼ���/ж�أ�������ֲ��
    /// 
    /// �޸ļ�¼
    ///   
    ///         2010.8.8 �汾��1.0 �׵�˧ ���
    /// 
    /// �汾��1.0
    /// 
    /// <author>
    ///        <name>�׵�˧</name>
    ///        <date>2010.8.8</date>
    /// </author> 
    /// </summary>
    public class PluginManager : IPluginManager
    {
        #region ����
        private IApplication _application = null;
        private IDictionary<int, IPlugin> _dicPlugin = new Dictionary<int, IPlugin>();
        private IDictionary<string, Type> _dicPluginType = new Dictionary<string, Type>();
        private bool _copyToMemory = true;
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
        public bool CopyToMemory
        {
            get
            {
                return _copyToMemory;
            }
            set
            {
                _copyToMemory = value;
            }
        }

        public IList<IPlugin> PluginList
        {
            get
            {
                return dicToIlist(_dicPlugin);
            }
            set { 

            }
        }
        private string pluginSign;
        public string PluginSign
        {
            set {  pluginSign = value; }
        }
        #endregion

        #region ���캯��
        public PluginManager(IApplication application)
        {
            Application = application;
            this.PluginChanged += delegate { };
        }
        public PluginManager()
        {
            this.PluginChanged += delegate { };
        }
        #endregion

        #region ���� ���� ж�� ���

        #region ���ز��
        public void LoadDefault()
        {
            LoadAllPlugins(AppDomain.CurrentDomain.BaseDirectory, true, this.pluginSign);
        }
        public void LoadDefault(string pluginSign)
        {
            this.pluginSign = pluginSign;
            LoadAllPlugins(AppDomain.CurrentDomain.BaseDirectory, true, this.pluginSign);
        }
        public IList<Type> LoadType( string pluginSign)
        {
            return LoadType(AppDomain.CurrentDomain.BaseDirectory, true, this.pluginSign);
        }
        public IList<Type> LoadType(string pluginFolderPath, bool searchChildFolder, string pluginSign)
        {
            TypeLoadConfig config = new TypeLoadConfig(CopyToMemory, false, pluginSign);
            IList<Type> pluginTypeList = ReflectionHelper.LoadDerivedType(typeof(IPlugin), pluginFolderPath, searchChildFolder, config);
         
            return pluginTypeList;
        }
        public void LoadAllPlugins(string pluginFolderPath, bool searchChildFolder, string pluginSign)
        {

            IList<Type> pluginTypeList = LoadType(pluginFolderPath, searchChildFolder, pluginSign);
            List<IPlugin> pluginList = new List<IPlugin>();
            for (int i = 0; i < pluginTypeList.Count; i++)
            {
                IPlugin plugin = (IPlugin)Activator.CreateInstance(pluginTypeList[i]);
                pluginList.Add(plugin);
            }
            pluginList.Sort(new PluginComparer());
            for (int i = 0; i < pluginList.Count; i++)
            {
                IPlugin plugin = pluginList[i];
                if (this._dicPlugin.ContainsKey(plugin.PluginKey))
                {
                    this._dicPlugin.Remove(plugin.PluginKey);
                }
                this._dicPlugin.Add(plugin.PluginKey, plugin);
                plugin.Application = this.Application;
                plugin.OnLoading(); 
                PluginChanged();
            }
           
        }
        #endregion

        #region ж�ز��
        public void Clear()
        {
            if (_dicPlugin.Count > 0)
            {
                foreach (IPlugin plugin in _dicPlugin.Values)
                {
                    try
                    {
                        plugin.BeforeTerminating();
                    }
                    catch
                    { }
                }
                _dicPlugin.Clear();
                PluginChanged();
            }
        }
        public void DynRemovePlugin(int pluginKey)
        {
            IPlugin plugin = GetPlugin(pluginKey);
            if (plugin != null)
            {
                plugin.PluginEnabled = false;
                try
                {
                    plugin.BeforeTerminating();
                }
                catch
                { }
                _dicPlugin.Remove(pluginKey);
                PluginChanged();
            }
        }
        #endregion

        #region ����ָ�����
        public void EnablePlugin(int pluginKey)
        {
            IPlugin plugin = GetPlugin(pluginKey);
            if (plugin != null && !plugin.PluginEnabled)
            {
                plugin.PluginEnabled = true;
                plugin.OnLoading();
            }
        }
        #endregion

        #region ָֹͣ�����
        public void DisEnablePlugin(int pluginKey)
        {
            IPlugin plugin = GetPlugin(pluginKey);
            if (plugin != null)
            {
                plugin.PluginEnabled = false;
                plugin.BeforeTerminating();
            }
        }

        #endregion

        #region ͨ�����Key��ȡָ�����
        public IPlugin GetPlugin(int pluginKey)
        {
            IPlugin plugin = null;
            if (_dicPlugin.ContainsKey(pluginKey))
            {
                plugin = _dicPlugin[pluginKey];
            }
            return plugin;
        }
        #endregion

        #region ͨ��������ȡ����
        public Type GetPluginType(string className)
        {
            Type type = null;
            if (_dicPluginType.ContainsKey(className))
            {
                type = _dicPluginType[className];
            }
            return type;
        }
        #endregion

        #region �Ƿ����ָ�����
        public bool ContainsPlugin(int pluginKey)
        {
            return this._dicPlugin.ContainsKey(pluginKey);
        }
        #endregion

        #endregion

        #region �¼� ����ı�����
        public event PluginChanged PluginChanged;
        #endregion

        #region �ֵ伯�ϵ�Listת��
        private IList<IPlugin> dicToIlist(IDictionary<int, IPlugin> dic)
        {
            IList<IPlugin> pluginList = new List<IPlugin>();
            foreach (KeyValuePair<int, IPlugin> kvp in dic)
            {
                if (kvp.Value != null)
                {
                    pluginList.Add(kvp.Value);
                }
            }
            return pluginList;
        }
        #endregion

        #region �������

        #endregion
    }
}
