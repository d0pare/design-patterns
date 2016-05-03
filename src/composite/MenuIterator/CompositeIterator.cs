using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MenuIterator
{
    public class CompositeIterator : IEnumerator<MenuComponent>
    {
        private readonly IEnumerator<MenuComponent> _iterator;
        private readonly Stack<IEnumerator<MenuComponent>> _stack = new Stack<IEnumerator<MenuComponent>>();
        private MenuComponent _current;

        public CompositeIterator(IEnumerator<MenuComponent> iterator)
        {
            _iterator = iterator;
            _stack.Push(iterator);
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (!_stack.Any())
            {
                _current = null;
                return false;
            }

            var iterator = _stack.Peek();
            if (!iterator.MoveNext())
            {
                _stack.Pop();
                return MoveNext();
            }

            _current = iterator.Current;

            if (_current is Menu)
            {
                _stack.Push(_current.CreateIterator());
            }

            return true;
        }

        public void Reset()
        {
            _current = null;
            _stack.Clear();
            _stack.Push(_iterator);
        }

        public MenuComponent Current => _current;

        object IEnumerator.Current => Current;
    }
}