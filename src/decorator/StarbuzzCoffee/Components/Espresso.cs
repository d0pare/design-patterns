using StarbuzzCoffee.Components;

namespace StarbuzzCoffee.Components
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }

        public override Size size { get => base.size; }
    }
}
