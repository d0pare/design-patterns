using StarbuzzCoffee.Components;
using StarbuzzCoffee.Decorators;

namespace StarbuzzCoffee.Decorators
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override Size size { get => _beverage.size; }

        public override string Description => _beverage.Description + ", Mocha";

        public override double Cost()
        {
            var sizeCost = new double[] { .60, .75, .90 };
            int i = (int)_beverage.size;
            return sizeCost[i] + _beverage.Cost();
        }
    }
}
