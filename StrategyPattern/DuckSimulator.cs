using StrategyPattern.Ducks;
using System;

/*
 * def: The strategy pattern defines a family of algorithms, encapsulate each one and makes them interchangeable.
 *      Strategy lets the algorithm vary independently from clients that use it.
 *      
 *      Learnings
 *          - Encapsulate what varies (in our case the behaviors)
 *          - Favor composition over inheritance
 *          - Program to interface not implementation
 */

namespace StrategyPattern
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckBase duck1 = new MallardDuck("Mallard Duck");
            duck1.Display();
            duck1.Swim();
            duck1.PerformFly();
            duck1.PerformQuack();
            Console.WriteLine();

            DuckBase duck2 = new DecoyDuck("Decoy Duck");
            duck2.Display();
            duck2.Swim();
            duck2.PerformFly();
            duck2.PerformQuack();
            Console.WriteLine();

            DuckBase duck3 = new RubberDuck("Rubber Duck");
            duck3.Display();
            duck3.Swim();
            duck3.PerformFly();
            duck3.PerformQuack();
        }
    }
}
