using PizzaShop.Entities.Ingredients;
using PizzaShop.Entities.Ingredients.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Factories.Implementations
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}
