using Common.Interfaces;
using CompositePattern.Component;
using CompositePattern.Leaf;
using System;

namespace CompositePattern.Composite
{
    public class DinerMenu : MenuComponent
    {
        private readonly int maxItems = 6;
        private int numberOfItems = 0;
        private readonly MenuComponent[] menuItems;
        private readonly IView view;
        private readonly string name;

        public DinerMenu(IView view, string name)
        {
            this.view = view;
            menuItems = new MenuComponent[maxItems];
            this.name = name;
        }

        public override void Add(MenuComponent menuItem)
        {
            if (numberOfItems >= maxItems)
            {
                throw new Exception("Sorry, menu is full. Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public override void Print()
        {
            view.DisplayMessage($"Welcome to {name}: \n");
            view.DisplayMessage("Diner menu: \n");

            foreach (var menu in menuItems)
            {
                menu?.Print();
            }
        }
    }
}
