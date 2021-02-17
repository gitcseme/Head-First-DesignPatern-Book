using StrategyPattern.Fly;
using StrategyPattern.Quack;
using System;

namespace StrategyPattern.Ducks
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck(string Name)
        {
            this.Name = Name;
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Rubber Duck");
        }
    }
}
