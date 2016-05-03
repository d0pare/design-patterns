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

        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Whip";
    }
}
