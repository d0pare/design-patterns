using System;

namespace DuckSimulator
{
    public class DuckSimulator
    {
        public static void Main(string[] args)
        {
            var simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            simulator.Simulate(duckFactory);
        }

        public void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Flock flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardOne = duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardThree = duckFactory.CreateMallardDuck();
            IQuackable mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: With Observer");

            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);

            Simulate(flockOfDucks);

            Console.WriteLine($"\nThe ducks quacked {QuackCounter.NumberOfQuacks} times");
        }

        public void Simulate(IQuackable duck) => duck.Quack();
    }
}
