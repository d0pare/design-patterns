using System;
using MiniDuckSimulator.Behaviors;

namespace MiniDuckSimulator.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a duck Decoy");
        }
    }
}