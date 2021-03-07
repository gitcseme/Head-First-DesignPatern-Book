using System;
using System.Collections.Generic;

namespace FacotyMethodPattern.Products.ConcreteProducts
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza(string Name, string Souce) 
            : base(Name, Souce)
        {
            Toppings = new List<string> { "Grated Rumario Veggie" };
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into triangular pieces");
        }
    }
}
