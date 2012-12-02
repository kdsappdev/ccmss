using System;
using System.Collections.Generic;
using System.Text;

namespace CCMS.Plugin
{
    /// <summary>
    /// PluginUtils
    /// 
    /// ���Ӧ�ó��򽻻�����������Ӧ�ó����������ݱ�Ҫ�Ĳ�����Ϣ
    /// 
    /// �޸ļ�¼
    ///   
    ///         2010.8.9 �汾��1.0 �׵�˧ ���
    /// 
    /// �汾��1.0
    /// 
    /// <author>
    ///        <name>�׵�˧</name>
    ///        <date>2010.8.9</date>
    /// </author> 
    /// </summary>
    public class PluginUtils
    {
        private static IDictionary<string, object> DicUtil = new Dictionary<string, object>();

        #region ע�Ṳ����Ϣ
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

        #region ��ȡ������Ϣ
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

        #region �Ƴ�������Ϣ
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
