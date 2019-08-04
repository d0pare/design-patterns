using StarbuzzCoffee.Components;
using StarbuzzCoffee.Decorators;

namespace StarbuzzCoffee.Decorators
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override Size size { get => _beverage.size; }

        public override double Cost()
        {
            var sizeCost = new double[] { .10, .15, .20 };
            int i = (int)_beverage.size;
            return sizeCost[i] + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Soy";
    }
}
