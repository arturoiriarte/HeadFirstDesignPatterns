using SimUDuck.Behaviors.Fly;
using SimUDuck.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimUDuck.Entities
{
    public abstract class Duck
    {
        public IFlyBehavior IFlyBehavior { get; set; }
        public IQuackBehavior IQuackBehavior { get; set; }

        public void PerformQuack()
        {
            IQuackBehavior.Quack();
        }

        public void PerformFly()
        {
            IFlyBehavior.Fly();
        }

        public void Swim() { Console.WriteLine("All ducks float, even decoys!"); }

        public abstract void Display();
    }
}
