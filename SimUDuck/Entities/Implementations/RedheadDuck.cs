using SimUDuck.Behaviors.Fly;
using SimUDuck.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Entities.Implementations
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            IQuackBehavior = new QuackBehavior();
            IFlyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("looks like a redhead");
        }
    }
}
