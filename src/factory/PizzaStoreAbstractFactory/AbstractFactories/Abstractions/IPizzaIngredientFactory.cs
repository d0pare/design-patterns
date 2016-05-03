using PizzaStoreAbstractFactory.Products.Ingredients;

namespace PizzaStoreAbstractFactory.AbstractFactories
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClam();
    }
}
