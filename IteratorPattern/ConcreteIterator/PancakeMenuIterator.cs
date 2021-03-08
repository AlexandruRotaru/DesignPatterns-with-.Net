using IteratorPattern.Aggregator;
using IteratorPattern.Iterator;
using System.Collections;

namespace IteratorPattern.ConcreteIterator
{
    public class PancakeMenuIterator : IMenuIterator<MenuItem>
    {
        private readonly ArrayList menuItems;
        private int index = 0;

        public PancakeMenuIterator(ArrayList items)
        {
            menuItems = items;
        }

        public bool HasNext()
        {
            if(index >= menuItems.Count || menuItems[index] == null) 
            {
                return false;
            }

            return true;
        }

        public MenuItem Next()
        {
            MenuItem item = (MenuItem)menuItems[index];

            index++;
            return item;
        }
    }
}
