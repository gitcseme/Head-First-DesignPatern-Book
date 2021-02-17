using StrategyPattern.Fly;
using StrategyPattern.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Ducks
{
    public abstract class DuckBase
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public DuckBase()
        {
        }

        public string Name { get; set; }
        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine($"{Name} is swiming");
        }

        public void PerformQuack()
        {
            flyBehavior.Fly();
        }

        public void PerformFly()
        {
            quackBehavior.Quack();
        }
    }
}
