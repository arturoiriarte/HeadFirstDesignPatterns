using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Behaviors.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        //Ducks that can't fly
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
