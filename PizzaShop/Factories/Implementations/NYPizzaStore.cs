using PizzaShop.Entities.Pizzas;
using PizzaShop.Entities.Pizzas.Implementations;
using PizzaShop.Entities.Pizzas.Implementations.NY;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Factories.Implementations
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYStyleCheesePizza();
                case PizzaType.Pepperoni:
                    return new NYStylePepperoniPizza();
                case PizzaType.Clam:
                    return new NYStyleClamPizza();
                case PizzaType.Veggie:
                    return new VeggiePizza();
                default:
                    break;
            }

            return null;
        }
    }
}
