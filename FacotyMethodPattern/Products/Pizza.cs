using System;
using System.Collections.Generic;
using System.Text;

namespace FacotyMethodPattern.Products
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Souce { get; set; }
        public List<string> Toppings = new List<string>();

        public Pizza(string Name, string Souce)
        {
            this.Name = Name;
            this.Souce = Souce;
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing: " + Name);
            Console.WriteLine("Adding souce...");
            Console.Write("Adding toppings...\n\t");
            foreach (var topping in Toppings) {
                Console.Write(topping + " ");
            }
            Console.WriteLine();
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 deg.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into pieces");
        }

        public void Box()
        {
            Console.WriteLine("Place the pizza in offical box");
        }
    }


}
