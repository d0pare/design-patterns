namespace DuckSimulator
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall() => new QuackCounter(new DuckCall());

        public override IQuackable CreateMallardDuck() => new QuackCounter(new MallardDuck());

        public override IQuackable CreateRedheadDuck() => new QuackCounter(new RedheadDuck());

        public override IQuackable CreateRubberDuck() => new QuackCounter(new RubberDuck());
    }
}