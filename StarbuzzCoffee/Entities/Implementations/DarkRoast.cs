using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Entities.Implementations
{
    public class DarkRoast : Beverage
    {
        public override double Cost => .99;

        public DarkRoast()
        {
            Description = "Dark Roast";
        }
    }
}
