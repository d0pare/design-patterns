using System.Collections.Generic;

namespace DinerMerger
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private readonly List<MenuItem> _items;
        private int _position;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _position < _items.Count;
        }

        public MenuItem Next()
        {
            return _items[_position++];
        }
    }
}