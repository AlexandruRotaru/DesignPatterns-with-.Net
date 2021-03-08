using Common.Interfaces;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza(IView view) : base(view)
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin crust dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Regianno Chese");
        }
    }
}
