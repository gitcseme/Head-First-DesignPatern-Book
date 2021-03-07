using System;
using System.Collections.Generic;
using System.Text;

namespace FacotyMethodPattern.Products.ConcreteProducts
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza(string Name, string Souce) 
            : base(Name, Souce)
        {
            Toppings = new List<string> { "Grated Reggiano Cheese" };
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal pieces");
        }
    }
}
