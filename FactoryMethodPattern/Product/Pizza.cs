using Common.Interfaces;
using System.Collections.Generic;

namespace FactoryMethodPattern.Product
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings;
        protected IView view;

        public Pizza(IView view)
        {
            this.view = view;
            toppings = new List<string>();
        }

        public virtual void Bake()
        {
            view.DisplayMessage("Bake for 25 minutes at 350.");
        }

        public virtual void Prepare()
        {
            view.DisplayMessage($"Preparing {name}");
            view.DisplayMessage("Tossing dough...");
            view.DisplayMessage("Adding sauce...");
            view.DisplayMessage("Adding toppings: ");

            foreach(var topping in toppings)
            {
                view.DisplayMessage($" {topping}");
            }
        }

        public virtual void Cut()
        {
            view.DisplayMessage("Cutting the pizza into diagonal slices.");
        }

        public virtual void Box()
        {
            view.DisplayMessage("Placing pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return name;
        }
    }
}
