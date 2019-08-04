using StarbuzzCoffee.Components;

namespace StarbuzzCoffee.Components
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }

        public override Size size { get => base.size;}
    }
}
