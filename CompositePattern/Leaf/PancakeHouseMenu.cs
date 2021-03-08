using Common.Interfaces;
using CompositePattern.Component;
using System.Collections.Generic;

namespace CompositePattern.Leaf
{
    public class PancakeHouseMenu : MenuComponent
    {
        private readonly List<MenuComponent> menuItems;
        private readonly IView view;
        private readonly string name;

        public PancakeHouseMenu(IView view, string name)
        {
            menuItems = new List<MenuComponent>();
            this.view = view;
            this.name = name;            
        }

        public override string GetName()
        {
            return name;
        }

        public override void Add(MenuComponent menuItem)
        {
            menuItems.Add(menuItem);
        }

        public override void Print()
        {
            view.DisplayMessage($"Welcome to {name}: \n");
            view.DisplayMessage("Our Pancake house menu: \n");

            foreach (var menu in menuItems)
            {
                menu.Print();
            }
        }
    }
}
