using System;
using System.Collections.Generic;
using System.Text;

namespace Membership.Plugins.Utils
{
    public class BaseUserControl : CCMS.Plugin.AbstractPlugin
    {
        public BaseUserControl()
        {
            _author = "王超";
            _appOrder = 3;
            _appKey = 6;
            _appName = "会员管理";
        }
    }
}
