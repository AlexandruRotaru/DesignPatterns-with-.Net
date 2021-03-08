using Common.Interfaces;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class NYStyleVeggyPizza : Pizza
    {
        public NYStyleVeggyPizza(IView view) : base(view)
        {
            name = "NY Style Sauce and Veggy Pizza";
            dough = "Thin crust dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Regianno Chese");
            toppings.Add("Pepper");
            toppings.Add("Tomato");
            toppings.Add("Olives");
        }
    }
}
