using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CCMS.Plugin
{
    /// <summary>
    /// IApplication
    /// 
    /// ���Ӧ����������ӿڣ�IPlugin�����loading()�и��ݵ�ǰ�����ṩ��Ӧ�÷���ӿ����������
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
    public interface IApplication
    {
        ToolStrip ToolMenu { get; }
        IPluginManager PluginManager { get; }
        MenuStrip MainMenu { get; }
        StatusStrip StatusBar { get; }
        TreeView TreeViemModule { get; }
        TabControl TabControl { get; }
    }
}
