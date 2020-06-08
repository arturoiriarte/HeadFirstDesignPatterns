using PizzaShop.Entities.Factories;
using PizzaShop.Entities.Pizzas;
using PizzaShop.Entities.Pizzas.Implementations;
using PizzaShop.Entities.Pizzas.Implementations.NY;
using PizzaShop.Factories;
using PizzaShop.Factories.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Factories.Implementations
{
    public class NYPizzaStore : PizzaStore
    {
        PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYStyleCheesePizza(ingredientFactory);
                case PizzaType.Pepperoni:
                    return new NYStylePepperoniPizza(ingredientFactory);
                case PizzaType.Clam:
                    return new NYStyleClamPizza(ingredientFactory);
                case PizzaType.Veggie:
                    return new VeggiePizza(ingredientFactory);
                default:
                    break;
            }

            return null;
        }
    }
}
