using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Plugins.Utils
{
    public class BaseUserControl : CCMS.Plugin.AbstractPlugin
    {
        public BaseUserControl()
        {
            _appOrder = 2;
            _appName = "保险管理";
        }
    }
}
