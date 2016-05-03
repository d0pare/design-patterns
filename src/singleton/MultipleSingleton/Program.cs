using System;
using MultipleSingleton.Singletons.Subclasses;

namespace MultipleSingleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var foo = CoolerSingleton.Instance;
            var bar = HotterSingleton.Instance;

            Console.WriteLine(foo == bar);
            Console.WriteLine(foo);
            Console.WriteLine(bar);
            Console.ReadKey();
        }
    }
}
