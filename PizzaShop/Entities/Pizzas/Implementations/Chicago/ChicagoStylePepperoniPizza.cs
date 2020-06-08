using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas.Implementations.Chicago
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            Name = "Chicago Style Pepperoni Pizza";
        }

        public override void Cut()
        {
            Console.WriteLine("<<Chicago square Style Cutting>>");
        }
    }
}
