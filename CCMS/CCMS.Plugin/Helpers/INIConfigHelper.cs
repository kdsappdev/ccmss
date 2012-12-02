using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace CCMS.Helpers
{
    public class INIConfigHelper
    {
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, System.Text.StringBuilder lpReturnedString, int nSize, string lpFileName);
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
        public static void WriteLoginInfo(string userName, string userPwd,string fileName)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userPwd))
            {
                WritePrivateProfileString("Config", "userName", CryptoTextBase.ProcessText(userName, true), fileName);
                WritePrivateProfileString("Config", "userPwd", CryptoTextBase.ProcessText(userPwd, true), fileName);
            }
        }
        public static void ReadLoginInfo(ref string userName,ref string userPwd, string fileName)
        {
            StringBuilder sb = new StringBuilder(255);
            GetPrivateProfileString("Config", "userName","",sb,sb.Capacity, fileName);
            userName = sb.ToString();
            if (!string.IsNullOrEmpty(userName))
            {
                CryptoTextBase.ProcessText(userName, false);
            }
            GetPrivateProfileString("Config", "userPwd", "", sb, sb.Capacity, fileName);
            userPwd = sb.ToString();
            if (!string.IsNullOrEmpty(userPwd))
            {
                CryptoTextBase.ProcessText(userPwd, false);
            }
        }
    }
}
