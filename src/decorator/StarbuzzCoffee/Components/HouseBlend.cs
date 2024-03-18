using StarbuzzCoffee.Components.Abstractions;

namespace StarbuzzCoffee.Components
{
    public class HouseBlend : IBeverage
    {
        public string Description { get; set; }

        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public double Cost()
        {
            return 0.89;
        }
    }
}
