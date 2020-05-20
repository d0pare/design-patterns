using System;

namespace MenuIterator
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            var iterator = _allMenus.CreateIterator();

            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                try
                {
                    if (menuComponent.IsVegetarian)
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotImplementedException) { }
            }
        }
    }
}