using System;

namespace StrategyPattern.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
