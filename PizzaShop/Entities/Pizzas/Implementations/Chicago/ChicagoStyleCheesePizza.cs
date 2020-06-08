using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas.Implementations.Chicago
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza"; 
            Dough = "Extra Thick Crust Dough"; 
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("<<Chicago square Style Cutting>>");
        }
    }
}
