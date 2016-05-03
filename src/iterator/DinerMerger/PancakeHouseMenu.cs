using System.Collections.Generic;

namespace DinerMerger
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();

            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99m);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99m);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49m);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59m);
        }

        public void AddItem(string name, string description,
                            bool vegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }

        public List<MenuItem> GetMenuItems()
        {
            return _menuItems;
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }

        public override string ToString()
        {
            return "Objectville Pancake House Menu";
        }
    }
}