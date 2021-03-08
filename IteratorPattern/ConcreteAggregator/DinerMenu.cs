using IteratorPattern.Aggregator;
using IteratorPattern.ConcreteIterator;
using IteratorPattern.Iterator;
using System;

namespace IteratorPattern.ConcreteAggregator
{
    public class DinerMenu : IMenu
    {
        private readonly int maxItems = 6;
        private int numberOfItems = 0;
        private readonly MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[maxItems];

            AddItem("Vegetarian BLT", "(Fackin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hotdog with relish, onions, ketchup.", false, 3.05);
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);

            if(numberOfItems >= maxItems)
            {
                throw new Exception("Sorry, menu is full. Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        // Old code, before Iterator
        //public MenuItem[] GetMenuItems()
        //{
        //    return menuItems;
        //}

        public IMenuIterator<MenuItem> CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
