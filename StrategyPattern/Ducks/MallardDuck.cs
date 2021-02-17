using StrategyPattern.Fly;
using StrategyPattern.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Ducks
{
    public class MallardDuck : DuckBase
    {
        public MallardDuck(string Name)
        {
            this.Name = Name;
            flyBehavior = new FlyWithWings();
            quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Real Mallard Duck");
        }
    }
}
