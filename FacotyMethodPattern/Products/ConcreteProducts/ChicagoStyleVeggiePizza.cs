using System;
using System.Collections.Generic;

namespace FacotyMethodPattern.Products.ConcreteProducts
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza(string Name, string Souce) 
            : base(Name, Souce)
        {
            Toppings = new List<string> { "Chicagoyian Hungarial Veggie" };
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into circular pieces");
        }
    }
}
