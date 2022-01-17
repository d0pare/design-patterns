using StarbuzzCoffee.Components.Abstractions;

namespace StarbuzzCoffee.Decorators
{
    public class Soy : ICondimentDecorator
    {
        public IBeverage BeverageComponent { get; set; }

        public string Description { get => $"{BeverageComponent.Description}, Soy"; }

        public Soy(IBeverage beverage)
        {
            BeverageComponent = beverage;
        }

        public double Cost()
        {
            return .15 + BeverageComponent.Cost();
        }
    }
}
