using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Behaviors.Quack
{
    public class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!!");
        }
    }
}
