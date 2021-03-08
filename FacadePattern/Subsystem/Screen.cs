using Common.Interfaces;

namespace FacadePattern.Subsystem
{
    public class Screen
    {
        private readonly IView view;

        public Screen(IView view)
        {
            this.view = view;
        }

        public void Down()
        {
            view.DisplayMessage($"Screen is in view position.");
        }

        public void Up()
        {
            view.DisplayMessage($"Screen is normal postion");
        }
    }
}
