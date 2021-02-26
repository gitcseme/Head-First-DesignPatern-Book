using DecoratorPattern.CoffeItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    public class Mocha : Coffe
    {
        private Coffe Coffe;

        public Mocha(Coffe coffe)
        {
            Price = 5.00;
            Coffe = coffe;
        }

        public override double Cost()
        {
            return Price + Coffe.Cost();
        }

        public override string GetDescription()
        {
            return Coffe.GetDescription() + $"Mocha {Price}\n";
        }
    }
}
