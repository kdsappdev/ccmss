using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Security.Permissions;
using Microsoft.Win32;

namespace CCMS.Helpers
{
    public class RegistryLicenseProvider : LicenseProvider
    {
        public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
        {

            if (context.UsageMode == LicenseUsageMode.Runtime)
            {

                RegistryKey licenseKey =
              Registry.CurrentUser.OpenSubKey("Software\\CCMS\\HostKeys");

                if (licenseKey != null)
                {
                    string strLic = (string)licenseKey.GetValue(type.GUID.ToString());
                    if (strLic != null)
                    {

                        if (String.Compare("Installed", strLic, false) == 0)
                        {

                            return new RuntimeRegistryLicense(type);
                        }
                    }
                }


                if (allowExceptions == true)
                {
                    throw new LicenseException(type,
                                               instance,
                                               "Your license is invalid");
                }


                return null;
            }
            else
            {
                return new DesigntimeRegistryLicense(type);
            }
        }
    }
    public class DesigntimeRegistryLicense : License
    {
        private Type type;

        public DesigntimeRegistryLicense(Type type)
        {
            if (type == null) throw new NullReferenceException("The licensed type reference may not be null.");
            this.type = type;
        }

        public override string LicenseKey
        {
            get
            {
                return type.GUID.ToString();
            }
        }

        public override void Dispose()
        {
        }
    }
    public class RuntimeRegistryLicense : License
    {
        private Type type;

        public RuntimeRegistryLicense(Type type)
        {
            if (type == null)
                throw new NullReferenceException("The licensed type reference may not be null.");
            this.type = type;
        }

        public override string LicenseKey
        {
            get
            {
                return type.GUID.ToString();
            }
        }
        public override void Dispose()
        {
        }
    }

}
