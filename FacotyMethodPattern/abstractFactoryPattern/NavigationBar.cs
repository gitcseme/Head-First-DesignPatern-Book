using FacotyMethodPattern.abstractFactoryPattern.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacotyMethodPattern.abstractFactoryPattern
{
    public class NavigationBar
    {
        public NavigationBar(UIFactory factory)
        {
            var button = factory.CreateButton();
            Console.WriteLine(button.Type);
        }
    }
}
