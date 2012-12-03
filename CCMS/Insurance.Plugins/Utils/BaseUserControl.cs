using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Plugins.Utils
{
    public class BaseUserControl : CCMS.Plugin.AbstractPlugin
    {
        public BaseUserControl()
        {
            _author = "王超";
            _appOrder = 2;
            _appKey = 6;
            _appName = "保险管理";
        }
    }
}
