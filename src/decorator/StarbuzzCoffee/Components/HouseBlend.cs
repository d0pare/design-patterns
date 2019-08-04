using StarbuzzCoffee.Components;

namespace StarbuzzCoffee.Components
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }

        public override Size size { get => base.size; set => base.size = value; }
    }
}
