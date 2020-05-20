using System;
using System.Globalization;

namespace DinerMerger
{
    public class Waitress
    {
        private readonly IMenu _pancakeHouseMenu;
        private readonly IMenu _dinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        public void PrintVegetarianMenu()
        {
            PrintVegetarianMenu(_pancakeHouseMenu.CreateIterator());
            PrintVegetarianMenu(_dinerMenu.CreateIterator());
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price.ToString(CultureInfo.InvariantCulture)} -- ");
                Console.WriteLine(menuItem.Description);
            }
        }

        private void PrintVegetarianMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                if (menuItem.IsVegetarian)
                {
                    Console.WriteLine($"{menuItem.Name} \t\t {menuItem.Price.ToString(CultureInfo.InvariantCulture)}");
                    Console.WriteLine("\t" + menuItem.Description);
                }
            }
        }

        private bool IsVegetarian(string name, IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                if (menuItem.Name == name && menuItem.IsVegetarian)
                {
                    return true;
                }
            }
            return false;
        }
    }
}