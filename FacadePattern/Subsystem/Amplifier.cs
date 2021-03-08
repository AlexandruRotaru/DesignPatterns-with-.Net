using Common.Interfaces;

namespace FacadePattern.Subsystem
{
    public class Amplifier
    {
        private readonly IView view;

        public Amplifier(IView view)
        {
            this.view = view;
        }

        public void On()
        {
            view.DisplayMessage("Amplifier is on.");
        }

        public void SetSource(BlueRayPlayer blueRay)
        {
            view.DisplayMessage($"Playing from {blueRay.GetType().Name}.");
        }

        public void SetSurroundSound()
        {
            view.DisplayMessage("Setting sound on 5.1 speakers.");
        }

        public void SetVolume(int volume)
        {
            view.DisplayMessage($"Volume is {volume}.");
        }

        public void Off()
        {
            view.DisplayMessage("Amplifier is off.");
        }
    }
}
