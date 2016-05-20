using System;

namespace DuckSimulator
{
    public class DuckCall : IQuackable
    {
        private Observable _observable;

        public DuckCall()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer) => _observable.RegisterObserver(observer);

        public void NotifyObservers() => _observable.NotifyObservers();

        public override string ToString() => "Duck Call";
    }
}