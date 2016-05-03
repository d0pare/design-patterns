using System;

namespace ChocolateBoiler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.Instance;
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();

            // will return the existing instance
            ChocolateBoiler boiler2 = ChocolateBoiler.Instance;

            Console.ReadKey();
        }
    }
}
