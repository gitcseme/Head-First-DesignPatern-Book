using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.CoffeItems
{
    public class Expresso : Coffe
    {
        public Expresso()
        {
            Price = 20.00;
            Description = $"\nEspresso coffe {Price}\n";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double Cost()
        {
            return Price;
        }
    }
}
