
using System;

namespace DinerMerger
{
    public class AlternatingDinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int _position;

        public AlternatingDinerMenuIterator(MenuItem[] items)
        {
            _items = items;
            _position = (int)DateTime.Now.DayOfWeek % 2;
        }

        public bool HasNext() => _position < _items.Length && _items[_position] != null;

        public MenuItem Next() => _items[_position+=2];

        public override string ToString()
        {
            return "Alternating Diner Menu Iterator";
        }
    }
}