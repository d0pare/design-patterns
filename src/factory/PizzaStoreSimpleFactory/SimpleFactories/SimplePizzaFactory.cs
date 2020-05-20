using PizzaStoreSimpleFactory.Pizzas;

namespace PizzaStoreSimpleFactory.SimpleFactories
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
            }

            return pizza;
        }
    }
}