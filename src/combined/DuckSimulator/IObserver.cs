namespace DuckSimulator
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}