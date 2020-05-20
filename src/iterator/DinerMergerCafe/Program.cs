using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinerMergerCafe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            CafeMenu cafeMenu = new CafeMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

            waitress.PrintMenu();
            waitress.PrintVegetarianMenu();

            Console.WriteLine("\nCustomer asks, is the Hotdog vegetarian?");
            Console.Write("Waitress says: ");
            Console.WriteLine(waitress.IsItemVegetarian("Hotdog") ? "Yes" : "No");
            Console.WriteLine("\nCustomer asks, are the Waffles vegetarian?");
            Console.Write("Waitress says: ");
            Console.WriteLine(waitress.IsItemVegetarian("Waffles") ? "Yes" : "No");
        }
    }
}
