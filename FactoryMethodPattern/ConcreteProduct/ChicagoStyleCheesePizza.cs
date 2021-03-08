using Common.Interfaces;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza(IView view) : base(view)
        {
            name = "Chicago Style Cheese Pizza";
            dough = "Extra thick crust dough";
            sauce = "Plum tomato Sauce";

            toppings.Add("Mozarella Chese");
        }

        public override void Cut()
        {
            view.DisplayMessage("Cutting the pizza into square slices");
        }
    }
}
