using Common.Interfaces;

namespace FacadePattern.Subsystem
{
    public class TheaterLights
    {
        private readonly IView view;

        public TheaterLights(IView view)
        {
            this.view = view;
        }

        public void Dim(int value)
        {
            view.DisplayMessage($"Dimming lights to {value}.");
        }

        public void On()
        {
            view.DisplayMessage("Lights are on.");
        }
    }
}
