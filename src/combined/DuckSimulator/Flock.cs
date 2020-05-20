using System.Collections.Generic;

namespace DuckSimulator
{
    public class Flock : IQuackable
    {
        private List<IQuackable> _ducks = new List<IQuackable>();

        public void Add(IQuackable duck) => _ducks.Add(duck);

        public void Quack()
        {
            foreach (var duck in _ducks)
            {
                duck.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var duck in _ducks)
            {
                duck.RegisterObserver(observer);
            }
        }

        public void NotifyObservers() {}

        public override string ToString() => "Flock of Ducks";
    }
}