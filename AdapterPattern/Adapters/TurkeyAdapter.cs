using AdapterPattern.Client;
using AdapterPattern.Target;

namespace AdapterPattern.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        // Adapter can adapt more than on interface.
        // IN addition to ITurkey, there can be more object types added
        // Adapter changes the the interface of one or more classes into one interface that the client expects.
        private readonly ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            for(int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
