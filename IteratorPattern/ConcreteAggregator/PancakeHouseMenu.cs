using IteratorPattern.Aggregator;
using IteratorPattern.ConcreteIterator;
using IteratorPattern.Iterator;
using System;
using System.Collections;

namespace IteratorPattern.ConcreteAggregator
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly ArrayList menuItems; 

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();

            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausge", false, 2.99);
            AddItem("Blueberry Pancake Breakfast", "Pancakes with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles with blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);

            menuItems.Add(menuItem);
        }

        // Old code, before Iterator
        //public ArrayList GetMenuItems()
        //{
        //    return menuItems;
        //}

        public IMenuIterator<MenuItem> CreateIterator()
        {
            return new PancakeMenuIterator(menuItems);
        }
    }
}
