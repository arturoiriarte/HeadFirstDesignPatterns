using SimUDuck.Behaviors.Fly;
using SimUDuck.Entities;
using SimUDuck.Entities.Implementations;
using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.PerformQuack();
            duck.PerformFly();
            duck.Swim();
            duck.Display();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.IFlyBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}
