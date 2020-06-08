using PizzaShop.Entities;
using PizzaShop.Entities.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Factory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza();
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza();
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza();
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
