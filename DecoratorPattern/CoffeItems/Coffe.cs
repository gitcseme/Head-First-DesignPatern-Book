using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.CoffeItems
{
    public abstract class Coffe
    {
        public double Price { get; set; }
        public string Description = "Unknown coffe";

        public abstract string GetDescription();
        
        public abstract double Cost();
    }
}
