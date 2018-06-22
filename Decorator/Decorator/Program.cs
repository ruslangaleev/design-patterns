using Decorator.Models;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPizza pizza = new ItalianPizza();

            // Просто итальянская пицца.
            Console.WriteLine("Название: {0}", pizza.Name);
            Console.WriteLine("Цена: {0}", pizza.GetCost());

            // Теперь итальянская пицца с томатами.
            pizza = new TomatoPizza(pizza);
            Console.WriteLine("Название: {0}", pizza.Name);
            Console.WriteLine("Цена: {0}", pizza.GetCost());

            Console.ReadLine();
        }
    }
}
