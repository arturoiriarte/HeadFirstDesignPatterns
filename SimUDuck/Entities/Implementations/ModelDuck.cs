using SimUDuck.Behaviors.Fly;
using SimUDuck.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Entities.Implementations
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            IFlyBehavior = new FlyNoWay();
            IQuackBehavior = new QuackBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
