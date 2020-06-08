using PizzaShop.Entities.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Factories
{
    public interface PizzaIngredientFactory
    {
        public Dough CreateDough(); 
        public Sauce CreateSauce(); 
        public Cheese CreateCheese();
    }
}
