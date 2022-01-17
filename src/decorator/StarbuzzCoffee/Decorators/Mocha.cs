using StarbuzzCoffee.Components.Abstractions;

namespace StarbuzzCoffee.Decorators
{
    public class Mocha : ICondimentDecorator
    {
        public IBeverage BeverageComponent { get; set; }

        public string Description { get => $"{BeverageComponent.Description}, Mocha"; }

        public Mocha(IBeverage beverage)
        {
            BeverageComponent = beverage;
        }

        public double Cost()
        {
            return .20 + BeverageComponent.Cost();
        }
    }
}
