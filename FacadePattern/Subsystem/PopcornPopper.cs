using Common.Interfaces;

namespace FacadePattern.Subsystem
{
    public class PopcornPopper
    {
        private readonly IView view;

        public PopcornPopper(IView view)
        {
            this.view = view;
        } 
        public void On()
        {
            view.DisplayMessage("Popcorn Popper is on.");
        }

        public void Pop()
        {
            view.DisplayMessage("Popping Popcorn.");
        }

        public void Off()
        {
            view.DisplayMessage("Popcorn Popper is off.");
        }
    }
}
