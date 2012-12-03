using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CCMS.Helpers
{
    public class PluginLicenseProvider : LicenseProvider
    {
        List<string> nsList = new List<string>();
        public PluginLicenseProvider()
        {
            nsList.Add("CCMS.Plugin");
            nsList.Add("CCMS.Plugins");
        }
        public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
        {
            PluginLicense lic=  new PluginLicense("");
            if (instance != null)
            {
                string ns = instance.GetType().AssemblyQualifiedName;
                Type t = instance.GetType();
                ns=t.Module.Name;
                if (nsList.Contains(ns))
                {
                    lic = new PluginLicense(ns);
                }
            }
            return lic;
        }
    }
    public class PluginLicense : License
    {
        string key = "";
        public PluginLicense(string key)
        {
            this.key = key;
        }
        public override void Dispose()
        {

        }
        public override string LicenseKey
        {
            get { return this.key; }
        }
    }
}
