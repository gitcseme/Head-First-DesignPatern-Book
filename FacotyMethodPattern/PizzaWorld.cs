using FacotyMethodPattern.Creators;
using FacotyMethodPattern.Creators.ConcreteCreators;
using FacotyMethodPattern.Products;
using System;

/**
 * The Factory Method Pattern defines an interface for creating objects, but let subclasses decide which class to instantiate.
 */

namespace FacotyMethodPattern
{
    class PizzaWorld
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("Cheese");
            Console.WriteLine("Customar ordered: " + pizza.Name + "\n");

            pizza = chicagoStore.OrderPizza("Veggie");
            Console.WriteLine("Customer ordered: " + pizza.Name);
        }
    }
}
