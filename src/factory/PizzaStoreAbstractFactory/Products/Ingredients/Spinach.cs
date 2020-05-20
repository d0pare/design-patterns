namespace PizzaStoreAbstractFactory.Products.Ingredients
{
    public class Spinach : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Spinach";
        }
    }
}
