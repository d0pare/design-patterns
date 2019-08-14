using System;
using PizzaStoreAbstractFactory.FactoryMethods;
using PizzaStoreAbstractFactory.Products.Pizzas;

namespace PizzaStoreAbstractFactory
{
    public class Program
    {
        public static Pizza pizza;

        public static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            PizzaStore californiaStore = new CaliforniaPizzaStore();

            pizza = nyStore.OrderPizza("cheese");
            WritePizza("Ethan");

            pizza = chicagoStore.OrderPizza("cheese");
            WritePizza("Joel");

            pizza = californiaStore.OrderPizza("cheese");
            WritePizza("Sebastian");

            pizza = nyStore.OrderPizza("clam");
            WritePizza("Ethan");

            pizza = chicagoStore.OrderPizza("clam");
            WritePizza("Joel");

            pizza = californiaStore.OrderPizza("clam");
            WritePizza("Sebastian");

            pizza = nyStore.OrderPizza("pepperoni");
            WritePizza("Ethan");

            pizza = chicagoStore.OrderPizza("pepperoni");
            WritePizza("Joel");

            pizza = californiaStore.OrderPizza("pepperoni");
            WritePizza("Sebastian");

            pizza = nyStore.OrderPizza("veggie");
            WritePizza("Ethan");

            pizza = chicagoStore.OrderPizza("veggie");
            WritePizza("Joel");

            pizza = californiaStore.OrderPizza("veggie");
            WritePizza("Sebastian");

            Console.ReadKey();
        }

        public static void WritePizza(string customerName)
        {
            Console.WriteLine(customerName + " ordered a " + pizza + "\n");
        }
    }
}
