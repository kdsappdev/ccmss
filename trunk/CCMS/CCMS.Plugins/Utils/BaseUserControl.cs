using System;
using System.Collections.Generic;
using System.Text;

namespace CCMS.Plugins.Utils
{
    public class BaseUserControl : CCMS.Plugin.AbstractPlugin
    {
        public BaseUserControl()
        {
            _appOrder = 1;
            _appName = "消费信贷";
        }
    }
}
