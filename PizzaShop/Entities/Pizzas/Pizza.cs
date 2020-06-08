using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas
{
    public abstract class Pizza
    {
        protected string Name { get; set; } = "Unknown pizza";
        protected string Dough { get; set; } = "Unknown dough";
        protected string Sauce { get; set; } = "Unknown sauce";

        protected List<string> Toppings { get; set; }

        public Pizza()
        {
            Toppings = new List<string>();
        }

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Tossing dough...");
            Console.WriteLine($"Adding sauce...");
            Console.WriteLine($"Adding toppings: ");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"    {topping}");
            }
        }
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
