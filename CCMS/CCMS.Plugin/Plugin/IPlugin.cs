using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace CCMS.Plugin
{
    /// <summary>
    /// IPlugin
    /// 
    /// 插件接口，所有插件都实现这个接口
    /// 
    /// 修改纪录
    ///   
    ///         2010.8.8 版本：1.0 孔德帅 添加
    /// 
    /// 版本：1.0
    /// 
    /// <author>
    ///        <name>孔德帅</name>
    ///        <date>2010.8.8</date>
    /// </author> 
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Application 应用程序提供的服务接口，用于将插件注册到应用程序中
        /// </summary>
        IApplication Application { get; set; }

        /// <summary>
        /// OnLoading 生命周期回调，当插件加载完毕被调用。可以从PluginUtils是获取主应用传递的参数来初始化插件
        /// </summary>
        void OnLoading();

        /// <summary>
        /// BeforeTerminating 生命周期回调，卸载插件前调用
        /// </summary>
        void BeforeTerminating();

        object PluginTag { get;set;}
        /// <summary>
        /// Enabled 插件是否启用
        /// </summary>
        bool PluginEnabled { get;set;}

        /// <summary>
        /// PluginKey 插件关键字，不同的插件其Key是不一样的
        /// </summary>
        int PluginKey { get;}

        /// <summary>
        /// ServiceName 插件提供的服务的名字	
        /// </summary>
        string PluginName { get; }

        /// <summary>
        /// Description 插件的描述信息	
        /// </summary>
        string Description { get;}

        /// <summary>
        /// Version 插件版本
        /// </summary>
        string Version { get;}

        /// <summary>
        /// Author 作者
        /// </summary>
        string Author { get;}

        int Order { get; }
        string AppName { get; }
        int AppOrder { get; }
        int AppKey { get; }
    }

    public class PluginHelper
    {
        public const string PluginSign1 = "Plugins.dll"; //所有的插件都以"Plugins.dll"结尾       
    }
    public class PluginComparer : IComparer<IPlugin>
    {
        public int Compare(IPlugin x, IPlugin y)
        {
            int result=0;
            if (x.Order > y.Order)
            {
                result = 1;
            }
            if (x.Order < y.Order)
            {
                result = -1;
            }
            if (x.Order == y.Order)
            {
                result = 0;
            }
            return result;
        }
    }
}
