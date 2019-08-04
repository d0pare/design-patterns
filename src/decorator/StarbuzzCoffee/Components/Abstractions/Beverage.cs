namespace StarbuzzCoffee.Components
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };

        public virtual Size size { get; set; } = Size.TALL;

        public virtual string Description { get; protected set; } = "Unknown Beverage";

        public abstract double Cost();
    }
}
