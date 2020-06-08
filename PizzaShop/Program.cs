using PizzaShop.Entities;
using PizzaShop.Entities.Pizzas;
using PizzaShop.Entities.Factories;
using PizzaShop.Entities.Factories.Implementations;
using System;

namespace PizzaShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new NYPizzaStore();
            store.OrderPizza(PizzaType.Cheese);
        }
    }
}
