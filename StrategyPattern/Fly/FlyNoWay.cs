using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("can't fly");
        }
    }
}
