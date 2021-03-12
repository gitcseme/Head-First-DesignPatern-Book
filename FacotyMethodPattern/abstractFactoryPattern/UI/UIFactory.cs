using System;
using System.Collections.Generic;
using System.Text;

namespace FacotyMethodPattern.abstractFactoryPattern.UI
{
    public abstract class UIFactory
    {
        public abstract Button CreateButton();
    }
}
