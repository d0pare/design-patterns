using PizzaStoreAbstractFactory.AbstractFactories;
using PizzaStoreAbstractFactory.Products.Pizzas;

namespace PizzaStoreAbstractFactory.FactoryMethods
{
    class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new CaliforniaPizzaIngredientFactory();

            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory) { Name = "California Style Cheese Pizza" };
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory) { Name = "California Style Veggie Pizza" };
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory) { Name = "California Style Clam Pizza" };
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory) { Name = "California Style Pepperoni Pizza" };
                    break;
            }

            return pizza;
        }
    }
}
