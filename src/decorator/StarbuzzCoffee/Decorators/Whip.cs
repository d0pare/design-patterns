using StarbuzzCoffee.Components;
using StarbuzzCoffee.Decorators;

namespace StarbuzzCoffee.Decorators
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override Size size { get => _beverage.size; }

        public override double Cost()
        {
            var sizeCost = new double[] { .25, .30, .35 };
            int i = (int)_beverage.size;
            return sizeCost[i] + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Whip";
    }
}
