using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("can fly with wings");
        }
    }
}
