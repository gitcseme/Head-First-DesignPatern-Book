using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Fly
{
    public class FlyWithRocket : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("can fly with rocket");
        }
    }
}
