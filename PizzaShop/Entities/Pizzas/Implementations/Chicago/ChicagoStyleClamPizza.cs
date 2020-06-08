using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas.Implementations.Chicago
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "Chicago Style Clam Pizza";
        }

        public override void Cut()
        {
            Console.WriteLine("<<Chicago square Style Cutting>>");
        }
    }
}
