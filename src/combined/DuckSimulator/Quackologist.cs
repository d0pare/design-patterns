using System;

namespace DuckSimulator
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck) => Console.WriteLine("Quackologist: " + duck + " just quacked.");

        public override string ToString() => "Quackologist";
    }
}