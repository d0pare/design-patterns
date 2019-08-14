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
            boiler2.Fill();
            boiler2.Boil(); 
            boiler2.Drain();  
            Console.ReadKey();
        }
    }
}
