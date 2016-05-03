using StarbuzzCoffee.Components;

namespace StarbuzzCoffee.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}
