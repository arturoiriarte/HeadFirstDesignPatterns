using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Behaviors.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
