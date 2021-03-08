using Common.Interfaces;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    class ChicagoStyleVeggyPizza : Pizza
    {
        public ChicagoStyleVeggyPizza(IView view) : base(view)
        {
            name = "Chicago Style Veggie Pizza";
            dough = "Extra thick crust dough";
            sauce = "Plum tomato Sauce";

            toppings.Add("Mozarella Chese");
            toppings.Add("Pepper");
            toppings.Add("Tomato");
            toppings.Add("Olives");
        }
    }
}
