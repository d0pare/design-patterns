using System.Collections.Generic;

namespace DuckSimulator
{
    public class Observable : IQuackObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer) => _observers.Add(observer);

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_duck);
            }
        }

        public IEnumerable<IObserver> GetOberservers => _observers;
    }
}