using System.Globalization;

namespace DinerMerger
{
    public class MenuItem
    {
        public MenuItem(string name, string description, bool vegetarian, decimal price)
        {
            Name = name;
            Description = description;
            IsVegetarian = vegetarian;
            Price = price;
        }

        public string Name { get; }
        public string Description { get; }
        public bool IsVegetarian { get; }
        public decimal Price { get; }

        public override string ToString()
        {
            return $"{Name}, ${Price.ToString(CultureInfo.InvariantCulture)} \r\n    {Description}";
        }
    }
}