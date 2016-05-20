using System;

namespace DuckSimulator
{
    public class DecoyDuck : IQuackable
    {
        private Observable _observable;

        public DecoyDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer) => _observable.RegisterObserver(observer);

        public void NotifyObservers() => _observable.NotifyObservers();
        
        public override string ToString() => "Decoy Duck";
    }
}