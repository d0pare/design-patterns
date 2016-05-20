namespace DuckSimulator
{
    public class QuackCounter : IQuackable
    {
        public static int NumberOfQuacks { get; private set; }

        private IQuackable _duck;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            NumberOfQuacks++;
        }

        public void RegisterObserver(IObserver observer) => _duck.RegisterObserver(observer);

        public void NotifyObservers() => _duck.NotifyObservers();

        public override string ToString() => _duck.ToString();
    }
}