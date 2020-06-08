using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Entities.Pizzas.Implementations
{
    public class VeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("<<Preparing>>");
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
