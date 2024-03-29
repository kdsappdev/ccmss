using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Diagnostics;

namespace CCMS.Helpers
{
    public static class MachineHelper
    {
        private static PerformanceCounter CpuPerformanceCounter = new PerformanceCounter("Process", "% Processor Time", "Idle");
        private static PerformanceCounter MemPerformanceCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use", "");//Available MBytes

        #region GetMacAddress 
        /// <summary>
        /// GetMacAddress ��ȡ����mac��ַ
        /// </summary>        
        public static IList<string> GetMacAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            IList<string> strArr = new List<string>();

            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                {
                    strArr.Add(mo["MacAddress"].ToString().Replace(":", ""));
                }
                mo.Dispose();
            }

            return strArr;
        }
        static string mac = "";
        public static string GetMacAddress2()
        {
            if (string.IsNullOrEmpty(mac))
            {
                IList<string> lt = GetMacAddress();
                if (lt != null && lt.Count > 0)
                {
                    mac = lt[0];
                }
            }
            return mac;
        }
        #endregion

        public static bool IsCurrentMachine(string macAddress)
        {
            IList<string> addList = MachineHelper.GetMacAddress();
            return addList.Contains(macAddress);
        }

        public static void GetPerformanceUsage(out float cpuAvailable, out float memoryUsage)
        {
            cpuAvailable = MachineHelper.CpuPerformanceCounter.NextValue();
            memoryUsage = MachineHelper.MemPerformanceCounter.NextValue();
        }
    }
}