
using System;
using System.Collections.Generic;

using System.Text;

namespace Menu.Help.Plugins.CheckUpdate
{
    public interface IAutoUpdater
    {
        void Update(bool isAuto);

        void RollBack();
    }
}
