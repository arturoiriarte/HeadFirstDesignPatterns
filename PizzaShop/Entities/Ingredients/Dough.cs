using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Ingredients
{
    public abstract class Dough
    {
        protected virtual string Name { get; set; } = "Pizza Dough";
    }
}
