namespace IteratorPattern.Iterator
{
    public interface IMenuIterator<T> where T : class
    {
        public bool HasNext();

        public T Next();
    }
}
