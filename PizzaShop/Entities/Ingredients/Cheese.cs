using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Ingredients
{
    public abstract class Cheese
    {
        protected virtual string Name { get; set; } = "Unknown cheese";
    }
}
