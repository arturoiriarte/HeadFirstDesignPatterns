using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Entities.Implementations
{
    public class HouseBlend : Beverage
    {
        public override double Cost => .89;

        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }
    }
}
