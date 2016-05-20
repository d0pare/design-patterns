namespace DuckSimulator
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}