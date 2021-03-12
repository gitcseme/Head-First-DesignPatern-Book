using FacotyMethodPattern.abstractFactoryPattern;
using FacotyMethodPattern.abstractFactoryPattern.Themes;
using FacotyMethodPattern.abstractFactoryPattern.UI;
using FacotyMethodPattern.Creators;
using FacotyMethodPattern.Creators.ConcreteCreators;
using FacotyMethodPattern.Products;
using System;

/**
 * The Factory Method Pattern defines an interface for creating objects, but let subclasses decide which class to instantiate.
 * 
 * The abstract factory pattern provides interface for creating families of related or dependent objects without specifying their concrete classes.
 */

namespace FacotyMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // FACTORY METHOD PATTERN
            //PizzaStore nyStore = new NYPizzaStore();
            //PizzaStore chicagoStore = new ChicagoPizzaStore();

            //Pizza pizza = nyStore.OrderPizza("Cheese");
            //Console.WriteLine("Customar ordered: " + pizza.Name + "\n");

            //pizza = chicagoStore.OrderPizza("Veggie");
            //Console.WriteLine("Customer ordered: " + pizza.Name);


            // ABSTRACT FACTORY PATTERN
            var android = new Android(new LightTheme());
            new NavigationBar(android);

            var apple = new Apple(new DarkTheme());
            new DropdownMenu(apple);

        }
    }
}
