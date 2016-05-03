namespace PizzaStoreAbstractFactory.Products.Ingredients
{
    public class ParmesanCheese : ICheese
    {
        string ICheese.ToString()
        {
            return "Shredded Parmesan";
        }
    }
}
