using StrategyPattern.Fly;
using StrategyPattern.Quack;
using System;

namespace StrategyPattern.Ducks
{
    public class DecoyDuck : DuckBase
    {
        public DecoyDuck(string Name)
        {
            this.Name = Name;
            flyBehavior = new FlyWithWings();
            quackBehavior = new SqueakQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Real Decoy Duck");
        }
    }
}
