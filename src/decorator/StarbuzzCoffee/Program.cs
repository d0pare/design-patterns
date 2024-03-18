using System;
using StarbuzzCoffee.Components;
using StarbuzzCoffee.Components.Abstractions;
using StarbuzzCoffee.Decorators;

namespace StarbuzzCoffee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("First Order");
            Console.WriteLine("---------------------------------------");
            IBeverage beverage = new Espresso();
            Console.WriteLine($"Item Descripion: {beverage.Description}");
            Console.WriteLine($"Cost= $ {beverage.Cost()}");

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Second Order");
            Console.WriteLine("---------------------------------------");
            IBeverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"Item Descripion: {beverage2.Description}");
            Console.WriteLine($"Cost= $ {beverage2.Cost()}");

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Third Order");
            Console.WriteLine("---------------------------------------");
            IBeverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"Item Descripion: {beverage3.Description}");
            Console.WriteLine($"Cost= $ {beverage3.Cost()}");

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Fourth Order");
            Console.WriteLine("---------------------------------------");
            IBeverage beverage4 = new HouseBlend();
            beverage4 = new Soy(beverage4);
            beverage4 = new Mocha(beverage4);
            beverage4 = new Whip(beverage4);
            beverage4 = new Soy(beverage4);
            beverage4 = new Mocha(beverage4);
            beverage4 = new Whip(beverage4);
            beverage4 = new Soy(beverage4);
            beverage4 = new Mocha(beverage4);
            beverage4 = new Whip(beverage4);
            Console.WriteLine($"Item Descripion: {beverage4.Description}");
            Console.WriteLine($"Cost= $ {beverage4.Cost()}");

            Console.WriteLine("\n\nThank You..");
            Console.ReadLine();
        }
    }
}
