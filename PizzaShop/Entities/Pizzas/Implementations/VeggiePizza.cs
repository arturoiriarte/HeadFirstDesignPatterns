using PizzaShop.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas.Implementations
{
    public class VeggiePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public VeggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }

        public override void Bake()
        {
            Console.WriteLine("<<Baking>>");
        }

        public override void Cut()
        {
            Console.WriteLine("<<Cutting>>");
        }

        public override void Box()
        {
            Console.WriteLine("<<Boxing>>");
        }
    }
}
