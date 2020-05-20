namespace PizzaStoreAbstractFactory.Products.Ingredients
{
    public class Mushroom : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Mushrooms";
        }
    }
}
