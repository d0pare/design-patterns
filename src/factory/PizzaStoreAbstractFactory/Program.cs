using System;
using PizzaStoreAbstractFactory.FactoryMethods;
using PizzaStoreAbstractFactory.Products.Pizzas;

namespace PizzaStoreAbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            PizzaStore californiaStore = new CaliforniaPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = californiaStore.OrderPizza("cheese");
            Console.WriteLine("Sebastian ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = californiaStore.OrderPizza("clam");
            Console.WriteLine("Sebastian ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = californiaStore.OrderPizza("pepperoni");
            Console.WriteLine("Sebastian ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = californiaStore.OrderPizza("veggie");
            Console.WriteLine("Sebastian ordered a " + pizza + "\n");

            Console.ReadKey();
        }
    }
}
