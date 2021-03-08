using Common.Interfaces;

namespace AdapterPattern.Client
{
    public class WildTurkey : ITurkey
    {
        private readonly IView view;

        public WildTurkey(IView view)
        {
            this.view = view;
        }

        public void Fly()
        {
            view.DisplayMessage("I fly short distance");
        }

        public void Gobble()
        {
            view.DisplayMessage("Gobble gobble");
        }
    }
}
