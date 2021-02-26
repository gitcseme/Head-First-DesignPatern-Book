using DecoratorPattern.CoffeItems;
using DecoratorPattern.Condiments;
using System;

namespace DecoratorPattern
{
    class CoffeShop
    {
        static void Main(string[] args)
        {
            Coffe coffe = new Expresso();   // Recursion is the fact behind. which keeps track of the encapsulated objects.
            coffe = new Mocha(coffe);       // In this line coffe = Mocha at runtime.
            coffe = new Milk(coffe);        // In this line coffe = Milk  at runtime.
            coffe = new Mocha(coffe);       // In this line coffe = Mocha at runtime.

            Console.WriteLine("Ingredients: " + coffe.GetDescription());
            Console.WriteLine("Total Cost: " + coffe.Cost());
        }
    }
}
