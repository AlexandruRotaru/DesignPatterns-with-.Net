using Common.Interfaces;

namespace CommandPattern.Receivers
{
    public class Light
    {
        private readonly IView view;
        private readonly string name;

        public Light(IView view, string name)
        {
            this.view = view;
            this.name = name;
        }

        public void On()
        {
            view.DisplayMessage($"{name} lights are on");
        }

        public void Off()
        {
            view.DisplayMessage($"{name} lights are off");
        }
    }
}
