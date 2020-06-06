using SimUDuck.Behaviors.Fly;
using SimUDuck.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck.Entities.Implementations
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            IFlyBehavior = new FlyNoWay();
            IQuackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a rubberduck");
        }
    }
}
