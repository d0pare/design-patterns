using StarbuzzCoffee.Components.Abstractions;

namespace StarbuzzCoffee.Decorators
{
    public interface ICondimentDecorator : IBeverage
    {
        public new abstract string Description { get;}

        public abstract IBeverage BeverageComponent { get; set; }
    }
}
