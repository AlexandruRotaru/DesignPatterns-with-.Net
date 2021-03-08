using IteratorPattern.Aggregator;
using IteratorPattern.Iterator;

namespace IteratorPattern.ConcreteIterator
{
    public class DinerMenuIterator : IMenuIterator<MenuItem>
    {
        private readonly MenuItem[] items;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if(position >= items.Length || items[position] == null)
            {
                return false;
            }

            return true;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = items[position];

            position++;
            return menuItem;
        }
    }
}
