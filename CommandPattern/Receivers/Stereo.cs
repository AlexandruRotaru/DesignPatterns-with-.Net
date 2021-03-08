using Common.Interfaces;

namespace CommandPattern.Receivers
{
    public class Stereo
    {
        private readonly IView view;

        public Stereo(IView view)
        {
            this.view = view;
        }

        public void On()
        {
            view.DisplayMessage("The stereo is on.");
        }

        public void SetRadio()
        {
            view.DisplayMessage("Radio is on.");
        }

        public void Off()
        {
            view.DisplayMessage("The stereo is off.");
        }

        public void SetCd()
        {
            view.DisplayMessage("Cd is set");
        }

        public void SetDvd()
        {
            view.DisplayMessage("Dvd is set.");
        }

        public void SetVolume(int volume)
        {
            view.DisplayMessage($"Volume is {volume}.");
        }
    }
}
