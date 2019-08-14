using PizzaStoreAbstractFactory.Products.Ingredients;

namespace PizzaStoreAbstractFactory.AbstractFactories
{
    public class CaliforniaPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ParmesanCheese();
        }

        public IClams CreateClam()
        {
            return new FriedClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SicilianPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new BBQSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new ArtichokeHearts() };
            return veggies;
        }
    }
}

