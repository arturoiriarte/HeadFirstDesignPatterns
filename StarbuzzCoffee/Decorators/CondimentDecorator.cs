using StarbuzzCoffee.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}
