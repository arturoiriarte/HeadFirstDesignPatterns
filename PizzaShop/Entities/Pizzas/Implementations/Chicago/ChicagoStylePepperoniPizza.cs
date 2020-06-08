using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas.Implementations.Chicago
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("<<Chicago Style Preparing>>");
        }

        public override void Bake()
        {
            Console.WriteLine("<<Chicago Style Baking>>");
        }

        public override void Cut()
        {
            Console.WriteLine("<<Chicago Style Cutting>>");
        }

        public override void Box()
        {
            Console.WriteLine("<<Chicago Style Boxing>>");
        }
    }
}
