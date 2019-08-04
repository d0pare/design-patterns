using System;
using StarbuzzCoffee.Components;
using StarbuzzCoffee.Decorators;

namespace StarbuzzCoffee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage.size = Beverage.Size.GRANDE;
            displayBeverage(beverage);

            Beverage beverage2 = new DarkRoast();
            beverage2.size = Beverage.Size.TALL;
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            displayBeverage(beverage2);

            Beverage beverage3 = new HouseBlend();
            beverage3.size = Beverage.Size.VENTI;
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            displayBeverage(beverage3);

            Console.ReadKey();
        }

        static void displayBeverage(Beverage bev)
        {
            Console.WriteLine(String.Format("{0,-10} {1,-50} ${2,-6}", bev.size.ToString(), bev.Description, bev.Cost()));
        }
    }
}
