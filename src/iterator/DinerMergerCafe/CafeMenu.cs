using System.Collections.Generic;

namespace DinerMergerCafe
{
    public class CafeMenu : IMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99m);
            AddItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69m);
            AddItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29m);
        }

        public void AddItem(string name, string description,
                            bool vegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem.Name, menuItem);
        }

        public Dictionary<string, MenuItem> GetItems()
        {
            return _menuItems;
        } 

        public IEnumerator<MenuItem> CreateIterator()
        {
            return _menuItems.Values.GetEnumerator();
        }
    }
}