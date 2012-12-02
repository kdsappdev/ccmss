using System;
using System.Collections.Generic;
using System.Text;

namespace CCMS.Plugin
{
    /// <summary>
    /// PluginUtils
    /// 
    /// 插件应用程序交互，用于宿主应用程序向插件传递必要的参数信息
    /// 
    /// 修改纪录
    ///   
    ///         2010.8.9 版本：1.0 孔德帅 添加
    /// 
    /// 版本：1.0
    /// 
    /// <author>
    ///        <name>孔德帅</name>
    ///        <date>2010.8.9</date>
    /// </author> 
    /// </summary>
    public class PluginUtils
    {
        private static IDictionary<string, object> DicUtil = new Dictionary<string, object>();

        #region 注册共享信息
        public static void RegisterObject(string name, object obj)
        {
            lock (PluginUtils.DicUtil)
            {
                if (PluginUtils.DicUtil.ContainsKey(name))
                {
                    PluginUtils.Remove(name);
                }

                PluginUtils.DicUtil.Add(name, obj);
            }
        }
        #endregion

        #region 获取共享信息
        public static object GetObject(string name)
        {
            lock (PluginUtils.DicUtil)
            {
                if (PluginUtils.DicUtil.ContainsKey(name))
                {
                    return PluginUtils.DicUtil[name];
                }
                return null;
            }
        }
        #endregion

        #region 移除共享信息
        public static void Remove(string name)
        {
            lock (PluginUtils.DicUtil)
            {
                if (PluginUtils.DicUtil.ContainsKey(name))
                {
                    PluginUtils.DicUtil.Remove(name);
                }
            }
        }
        #endregion

        #region Clear
        public static void Clear()
        {
            lock (PluginUtils.DicUtil)
            {
                PluginUtils.DicUtil.Clear();
            }
        }
        #endregion
    }
}
