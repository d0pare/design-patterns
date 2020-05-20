namespace PizzaStoreAbstractFactory.Products.Ingredients
{
    public class FreshClams : IClams
    {
        string IClams.ToString()
        {
            return "Fresh Clams from Long Island Sound";
        }
    }
}
