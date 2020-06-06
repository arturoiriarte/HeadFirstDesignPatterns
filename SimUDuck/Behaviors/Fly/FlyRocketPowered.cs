using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Behaviors.Fly
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
