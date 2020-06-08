using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace StarbuzzCoffee.Entities.Implementations
{
    public class Espresso : Beverage
    {
        public override double Cost => 1.99;

        public Espresso()
        {
            Description = "Espresso";
        }
    }
}
