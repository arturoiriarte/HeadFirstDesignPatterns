using PizzaShop.Entities.Factories;
using PizzaShop.Entities.Pizzas;
using PizzaShop.Entities.Pizzas.Implementations.Chicago;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Factories.Implementations
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoStyleCheesePizza();
                case PizzaType.Pepperoni:
                    return new ChicagoStylePepperoniPizza();
                case PizzaType.Clam:
                    return new ChicagoStyleClamPizza();
                case PizzaType.Veggie:
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
