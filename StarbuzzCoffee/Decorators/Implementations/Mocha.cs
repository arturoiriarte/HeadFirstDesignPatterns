using StarbuzzCoffee.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Decorators.Implementations
{
    public class Mocha : CondimentDecorator
    {
        private Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description { get => $"{beverage.Description}, Mocha"; }

        public override double Cost => beverage.Cost + .20;
    }
}
