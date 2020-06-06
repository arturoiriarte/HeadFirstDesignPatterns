using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Behaviors.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        //Ducks with wings
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
