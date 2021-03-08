using Common.Interfaces;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza(IView view) : base(view)
        {
            name = "NY Style Sauce and Pepperoni Pizza";
            dough = "Thin crust dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Regianno Chese");
            toppings.Add("Pepperoni");
        }
    }
}
