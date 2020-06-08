using StarbuzzCoffee.Decorators.Implementations;
using StarbuzzCoffee.Entities;
using StarbuzzCoffee.Entities.Implementations;
using System;

namespace StarbuzzCoffee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new HouseBlend();
            Console.WriteLine($"{beverage.Description}: {beverage.Cost}");

            Beverage beverage1 = new Espresso();
            Console.WriteLine($"{beverage1.Description}: {beverage1.Cost}");

            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);

            Console.WriteLine($"{beverage1.Description}: {beverage1.Cost}");
        }
    }
}
