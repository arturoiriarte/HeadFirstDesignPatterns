using PizzaShop.Entities;
using PizzaShop.Entities.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Factories
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaType type);
    }
}
