using System;

namespace StrategyPattern.Quack
{
    public class SqueakQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("squeaks");
        }
    }
}
