using PizzaShop.Entities.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas
{
    public abstract class Pizza
    {
        protected string Name { get; set; } = "Unknown pizza";
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected Cheese Cheese { get; set; }

        protected List<string> Toppings { get; set; }

        public Pizza()
        {
            Toppings = new List<string>();
        }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine($"Bake for 25 minutes at 350");

        }
        public virtual void Cut()
        {
            Console.WriteLine($"Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine($"Place pizza in official PizzaStore box");
        }
    }
}
