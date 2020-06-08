using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Entities.Implementations
{
    public class Decaf : Beverage
    {
        public override double Cost => 1.05;

        public Decaf()
        {
            Description = "Decaf";
        }
    }
}
