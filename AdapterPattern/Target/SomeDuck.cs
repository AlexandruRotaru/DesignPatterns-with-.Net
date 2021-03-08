using Common.Interfaces;

namespace AdapterPattern.Target
{
    public class SomeDuck : IDuck
    {
        private readonly IView view;

        public SomeDuck(IView view)
        {
            this.view = view;
        }

        public void Fly()
        {
            view.DisplayMessage("Flying DUCK");
        }

        public void Quack()
        {
            view.DisplayMessage("QUACK");
        }
    }
}
