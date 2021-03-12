using FacotyMethodPattern.abstractFactoryPattern.UI;
using System;

namespace FacotyMethodPattern.abstractFactoryPattern
{
    public class DropdownMenu
    {
        public DropdownMenu(UIFactory factory)
        {
            var button = factory.CreateButton();
            Console.WriteLine(button.Type);
        }
    }
}
