using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Entities
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; } = "Unknown Beverage";
        public abstract double Cost { get; }
    }
}
