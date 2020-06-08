using PizzaShop.Entities;
using PizzaShop.Factory;
using System;

namespace PizzaShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);
            Pizza pizza = store.OrderPizza(PizzaType.Cheese);
        }
    }
}
