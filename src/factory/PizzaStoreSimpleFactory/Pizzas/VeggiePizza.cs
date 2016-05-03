using PizzaStoreSimpleFactory.Pizzas;

namespace PizzaStoreSimpleFactory.Pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
            Dough = "Crust";
            Sauce = "Marinara sauce";

            Toppings.Add("Shredded mozzarella");
            Toppings.Add("Grated parmesan");
            Toppings.Add("Diced onion");
            Toppings.Add("Sliced mushrooms");
            Toppings.Add("Sliced red pepper");
            Toppings.Add("Sliced black olives");
        }
    }
}