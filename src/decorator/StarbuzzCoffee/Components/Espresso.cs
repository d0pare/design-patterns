using StarbuzzCoffee.Components.Abstractions;

namespace StarbuzzCoffee.Components
{
    public class Espresso : IBeverage
    {
        public string Description { get; set; }

        public Espresso()
        {
            Description = "Espresso";
        }

        public double Cost()
        {
            return 1.99;
        }
    }
}
