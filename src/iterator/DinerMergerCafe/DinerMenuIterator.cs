using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerMergerCafe
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private readonly IEnumerator _enumerator;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _enumerator = menuItems.GetEnumerator();
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return _enumerator.MoveNext();
        }

        public void Reset()
        {
            _enumerator.Reset();
        }

        public MenuItem Current => (MenuItem) _enumerator.Current;

        object IEnumerator.Current => Current;
    }
}