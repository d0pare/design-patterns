namespace PizzaStoreAbstractFactory.Products.Ingredients
{
    public class FrozenClams : IClams
    {
        string IClams.ToString()
        {
            return "Frozen Clams from Chesapeake Bay";
        }
    }
}
