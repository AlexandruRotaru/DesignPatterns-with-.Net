using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregator
{
    public interface  IMenu
    {
        public IMenuIterator<MenuItem> CreateIterator();
    }
}
