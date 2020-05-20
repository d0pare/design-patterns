using System;
using System.Collections.Generic;
using System.Globalization;

namespace MenuIterator
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool vegetarian, decimal price)
        {
            Name = name;
            Description = description;
            IsVegetarian = vegetarian;
            Price = price;
        }

        public override string Name { get; }
        public override string Description { get; }
        public override bool IsVegetarian { get; }
        public override decimal Price { get; }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return new NullIterator();
        }

        public override void Print()
        {
            Console.Write(" " + Name);
            if (IsVegetarian)
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + Price.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("    --" + Description);
        }
    }
}