using System;

namespace DinerMerger
{
    public class DinerMenu : IMenu
    {
        private const int MAX_ITEMS = 6;
        private int _numberOfItems;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99m);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99m);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29m);
            AddItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05m);
            AddItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99m);
            AddItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89m);
        }

        public void AddItem(string name, string description,
                            bool vegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full!  Can't add item to menu");
            }
            else
            {
                _menuItems[_numberOfItems++] = menuItem;
            }
        }

        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
            // To test Alternating menu items, comment out above line,
            // and uncomment the line below.
            //return new AlternatingDinerMenuIterator(menuItems);
        }
    }
}