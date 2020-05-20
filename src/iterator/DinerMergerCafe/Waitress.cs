using System;
using System.Collections.Generic;
using System.Globalization;

namespace DinerMergerCafe
{
    public class Waitress
    {
        private readonly IMenu _pancakeHouseMenu;
        private readonly IMenu _dinerMenu;
        private readonly IMenu _cafeMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
            _cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = _pancakeHouseMenu.CreateIterator();
            var dinerIterator = _dinerMenu.CreateIterator();
            var cafeIterator = _cafeMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
            Console.WriteLine("\nDINNER");
            PrintMenu(cafeIterator);
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\nVEGETARIAN MENU\n---------------");
            PrintVegetarianMenu(_pancakeHouseMenu.CreateIterator());
            PrintVegetarianMenu(_dinerMenu.CreateIterator());
            PrintVegetarianMenu(_cafeMenu.CreateIterator());
        }

        public bool IsItemVegetarian(string name)
        {
            IEnumerator<MenuItem> pancakeIterator = _pancakeHouseMenu.CreateIterator();
            if (IsVegetarian(name, pancakeIterator))
            {
                return true;
            }
            IEnumerator<MenuItem> dinerIterator = _dinerMenu.CreateIterator();
            if (IsVegetarian(name, dinerIterator))
            {
                return true;
            }
            IEnumerator<MenuItem> cafeIterator = _cafeMenu.CreateIterator();
            if (IsVegetarian(name, cafeIterator))
            {
                return true;
            }
            return false;
        }

        private void PrintMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price.ToString(CultureInfo.InvariantCulture)} -- ");
                Console.WriteLine(menuItem.Description);
            }
        }

        private void PrintVegetarianMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                if (menuItem.IsVegetarian)
                {
                    Console.WriteLine($"{menuItem.Name} \t\t {menuItem.Price.ToString(CultureInfo.InvariantCulture)}");
                    Console.WriteLine("\t" + menuItem.Description);
                }
            }
        }

        private bool IsVegetarian(string name, IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                if (menuItem.Name == name && menuItem.IsVegetarian)
                {
                    return true;
                }
            }
            return false;
        }
    }
}