using StarbuzzCoffee.Components.Abstractions;

namespace StarbuzzCoffee.Components
{
    public class DarkRoast : IBeverage
    {
        public string Description { get; set; }

        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }     

        public double Cost()
        {
            return 0.99;
        }
    }
}
