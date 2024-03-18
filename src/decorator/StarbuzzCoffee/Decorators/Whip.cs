using StarbuzzCoffee.Components.Abstractions;

namespace StarbuzzCoffee.Decorators
{
    public class Whip : ICondimentDecorator
    {
        public IBeverage BeverageComponent { get; set; }

        public string Description { get => $"{BeverageComponent.Description}, Whip"; }

        public Whip(IBeverage beverage)
        {
            BeverageComponent = beverage;
        }

        public double Cost()
        {
            return BeverageComponent.Cost() + 0.10;
        }
    }
}
