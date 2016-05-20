namespace DuckSimulator
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall() => new DuckCall();

        public override IQuackable CreateMallardDuck() => new MallardDuck();

        public override IQuackable CreateRedheadDuck() => new RedheadDuck();

        public override IQuackable CreateRubberDuck() => new RubberDuck();
    }
}