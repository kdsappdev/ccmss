using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Help.Plugins.CheckUpdate
{
    public class ConstFile
    {
        public const string TEMPFOLDERNAME = "TempFolder";
        public const string CONFIGFILEKEY = "config_";
        public const string FILENAME = "AutoUpdater.config";
        public const string ROOLBACKFILE = "CCMS.exe";
        public const string MESSAGETITLE = "在线升级";
        public const string CANCELORNOT = ROOLBACKFILE+"更新正在进行中。你真的要取消吗?";
        public const string APPLYTHEUPDATE = "程序需要重新启动以应用此更新，请单击“确定”，重新启动程序!";
        public static string NOTNETWORK = string.Format("{0}更新是不成功的。{0}现在将重新启动。请再次尝试更新。", ROOLBACKFILE);
    }
}
