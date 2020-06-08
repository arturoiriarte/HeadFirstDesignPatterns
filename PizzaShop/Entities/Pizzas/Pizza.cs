using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas
{
    public abstract class Pizza
    {
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}
