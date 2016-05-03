namespace DinerMerger
{
    public class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int _position;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext() => _position < _items.Length && _items[_position] != null;

        public MenuItem Next() => _items[_position++];
    }
}