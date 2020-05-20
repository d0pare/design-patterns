namespace DuckSimulator
{
    public class GooseAdapter : IQuackable
    {
        private Goose _goose;
        private Observable _observable;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }

        public void Quack()
        {
            _goose.Honk();
        }

        public void RegisterObserver(IObserver observer) => _observable.RegisterObserver(observer);

        public void NotifyObservers() => _observable.NotifyObservers();

        public override string ToString() => "Goose pretending to be a Duck";
    }
}