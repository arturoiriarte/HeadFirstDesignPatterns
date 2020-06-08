using PizzaShop.Entities.Ingredients;
using PizzaShop.Entities.Ingredients.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Factories.Implementations
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
