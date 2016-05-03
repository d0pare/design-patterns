using System;
using MiniDuckSimulator.Behaviors;

namespace MiniDuckSimulator.Ducks
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Red Headed duck");
        }
    }
}