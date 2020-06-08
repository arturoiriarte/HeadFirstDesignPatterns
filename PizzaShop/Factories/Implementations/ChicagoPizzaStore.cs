using PizzaShop.Entities.Factories;
using PizzaShop.Entities.Pizzas;
using PizzaShop.Entities.Pizzas.Implementations;
using PizzaShop.Entities.Pizzas.Implementations.Chicago;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Factories.Implementations
{
    public class ChicagoPizzaStore : PizzaStore
    {
        PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoStyleCheesePizza(ingredientFactory);
                case PizzaType.Pepperoni:
                    return new ChicagoStylePepperoniPizza(ingredientFactory);
                case PizzaType.Clam:
                    return new ChicagoStyleClamPizza(ingredientFactory);
                case PizzaType.Veggie:
                    return new VeggiePizza(ingredientFactory); 
                default:
                    break;
            }
            return null;
        }
    }
}
