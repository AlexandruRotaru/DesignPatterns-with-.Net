using Common.Interfaces;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza(IView view) : base(view)
        {
            name = "Chicago Style Pepperoni Pizza";
            dough = "Extra thick crust dough";
            sauce = "Plum tomato Sauce";

            toppings.Add("Mozarella Chese");
            toppings.Add("Pepperoni");
        }

        public override void Cut()
        {
            view.DisplayMessage("Cutting the pizza into slices");
        }
    }
}
