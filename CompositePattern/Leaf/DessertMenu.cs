using Common.Interfaces;
using CompositePattern.Component;
using System.Collections;

namespace CompositePattern.Leaf
{
    public class DessertMenu : MenuComponent
    {
        private readonly ArrayList menuItems;
        private readonly IView view;

        public DessertMenu(IView view)
        {
            menuItems = new ArrayList();
            this.view = view;
        }

        public override void Add(MenuComponent menuItem)
        {
            menuItems.Add(menuItem);
        }

        public override void Print()
        {
            view.DisplayMessage("Our Dessert menu: \n");

            foreach (var menu in menuItems)
            {
               (menu as MenuComponent)?.Print();
            }
        }
    }
}
