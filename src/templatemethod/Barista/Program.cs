using System;

namespace Barista
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffee.PrepareRecipe();


            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();

            Console.WriteLine("\nMaking tea...");
            teaHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeHook.PrepareRecipe();
        }
    }
}
