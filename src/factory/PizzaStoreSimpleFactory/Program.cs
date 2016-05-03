using System;
using PizzaStoreSimpleFactory.Pizzas;
using PizzaStoreSimpleFactory.SimpleFactories;

namespace PizzaStoreSimpleFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.Name);

            pizza = store.OrderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.Name);

            Console.ReadKey();
        }
    }
}
