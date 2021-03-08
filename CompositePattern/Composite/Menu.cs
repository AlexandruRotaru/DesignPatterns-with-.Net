using Common.Interfaces;
using CompositePattern.Component;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern.Composite
{
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> menuComponents;
        private readonly string name;
        private readonly string description;
        private readonly IView view;

        public Menu(string name, string description, IView view)
        {
            this.name = name;
            this.description = description;
            this.view = view;
            menuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return menuComponents.ElementAt(i);
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override void Print()
        {
            view.DisplayMessage($"\n{name}");
            view.DisplayMessage($" ,{description}");
            view.DisplayMessage("-----------------");

            // foreach uses an iterator internally
            foreach(var item in menuComponents)
            {
                item.Print();
            }
        }
    }
}
