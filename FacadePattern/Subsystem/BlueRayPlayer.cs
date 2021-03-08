using Common.Interfaces;

namespace FacadePattern.Subsystem
{
    public class BlueRayPlayer
    {
        private readonly IView view;

        public BlueRayPlayer(IView view)
        {
            this.view = view;
        }

        public void On()
        {
            view.DisplayMessage("Blue Ray Player is on.");
        }

        public void Play(string movie)
        {
            view.DisplayMessage($"Playing {movie}.");
        }

        public void Stop()
        {
            view.DisplayMessage("Stoped playing disc content.");
        }

        public void Eject()
        {
            view.DisplayMessage("Ejected disc.");
        }

        public void Off()
        {
            view.DisplayMessage("Blue Ray Player is off.");
        }
    }
}
