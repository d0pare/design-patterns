namespace StarbuzzCoffee.Components.Abstractions
{
    public interface IBeverage
    {
        public string Description
        {
            get
            {
                return "Unknown Type";
            }
        }

        public abstract double Cost();
    }
}
