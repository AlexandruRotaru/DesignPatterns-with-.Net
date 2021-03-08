using Common.Interfaces;

namespace FacadePattern.Subsystem
{
    public class Projector
    {
        private readonly IView view;

        public Projector(IView view)
        {
            this.view = view;
        }

        public void On()
        {
            view.DisplayMessage("Projector is on.");
        }

        public void Off()
        {
            view.DisplayMessage("Projector is off.");
        }
    }
}
