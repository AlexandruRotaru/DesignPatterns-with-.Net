using Common.Interfaces;

namespace CommandPattern.Receivers
{
    public class Garage
    {
        private readonly IView view;

        public Garage(IView view)
        {
            this.view = view;
        }

        public void Open()
        {
            view.DisplayMessage("Openning garage door...");
            view.DisplayMessage("....");
            view.DisplayMessage("....");
            view.DisplayMessage("Garage door opened.");
        }

        public void Close()
        {
            view.DisplayMessage("Closing garage door...");
            view.DisplayMessage("....");
            view.DisplayMessage("....");
            view.DisplayMessage("Garage door closed.");
        }

        public void Stop()
        {
            view.DisplayMessage("Action stopped");
        }

        public void LightsOn()
        {
            view.DisplayMessage("Garage ligths ar on.");
        }

        public void LightsOff()
        {
            view.DisplayMessage("Garage ligths ar of.");
        }
    }
}
