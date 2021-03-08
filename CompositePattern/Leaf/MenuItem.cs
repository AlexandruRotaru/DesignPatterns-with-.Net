using Common.Interfaces;
using CompositePattern.Component;

namespace CompositePattern.Leaf
{
    public class MenuItem : MenuComponent
    {
        private readonly string name;
        private readonly string description;
        private readonly bool isVegetarian;
        private readonly double price;
        private readonly IView view;

        public MenuItem(string name, string description, bool isVegetarian, double price, IView view)
        {
            this.name = name;
            this.description = description;
            this.isVegetarian = isVegetarian;
            this.price = price;
            this.view = view;
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override bool GetIsVegetarian()
        {
            return isVegetarian;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override void Print()
        {
            view.DisplayMessage($"   {name}");
            if(isVegetarian)
            {
                view.DisplayMessage("(v)");
            }
            view.DisplayMessage($", {price}");
            view.DisplayMessage($"  ----- {description}");
        }
    }
}
