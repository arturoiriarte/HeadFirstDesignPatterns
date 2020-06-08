using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas.Implementations.NY
{
    public class NYStyleClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("<<<NY Style Preparing>>");
        }

        public override void Bake()
        {
            Console.WriteLine("<<<NY Style Baking>>");
        }

        public override void Cut()
        {
            Console.WriteLine("<<<NY Style Cutting>>");
        }

        public override void Box()
        {
            Console.WriteLine("<<<NY Style Boxing>>");
        }
    }
}
