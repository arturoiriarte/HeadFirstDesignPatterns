using PizzaShop.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas.Implementations.Chicago
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public ChicagoStylePepperoniPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;

            Name = "Chicago Style Pepperoni Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }

        public override void Cut()
        {
            Console.WriteLine("<<Chicago square Style Cutting>>");
        }
    }
}
