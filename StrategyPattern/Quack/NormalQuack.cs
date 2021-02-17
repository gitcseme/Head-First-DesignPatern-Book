using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Quack
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("quacks");
        }
    }
}
