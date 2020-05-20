using System;
using Ducks.Models.Ducks;
using Ducks.Models.Turkeys;

namespace Ducks.Adapters
{
    public class DuckAdapter : ITurkey //target interface
    {
        //adaptee interface
        private readonly IDuck _duck;
        private readonly Random _random;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
            _random = new Random();
        }

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            if (_random.Next(5) == 0)
            {
                _duck.Fly();
            }
        }
    }
}