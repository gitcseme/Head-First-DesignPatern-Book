using System;
using System.Collections.Generic;

namespace FacotyMethodPattern.Products.ConcreteProducts
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza(string Name, string Souce) 
            : base(Name, Souce)
        {
            Toppings = new List<string> { "Shredded Mozzarella Cheese" };
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square pieces");
        }
    }
}
