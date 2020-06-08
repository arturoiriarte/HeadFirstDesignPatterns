using PizzaShop.Entities;
using PizzaShop.Entities.Pizzas;
using PizzaShop.Entities.Factories;
using PizzaShop.Entities.Factories.Implementations;
using System;
using PizzaShop.Factories.Implementations;

namespace PizzaShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new NYPizzaStore();
            store.OrderPizza(PizzaType.Cheese);

            PizzaStore store1 = new ChicagoPizzaStore();
            store1.OrderPizza(PizzaType.Cheese);
        }
    }
}
