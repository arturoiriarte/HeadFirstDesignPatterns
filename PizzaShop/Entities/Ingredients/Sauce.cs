using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Ingredients
{
    public abstract class Sauce
    {
        protected virtual string Name { get; set; } = "Unknown sauce";
    }
}
