using Common.Interfaces;

namespace TemplateMethodPattern
{
    public class Coffee : CaffeineBeverage
    {
        public Coffee(IView view)
        {
            this.view = view;
        }

        protected override void AddCondiments()
        {
            view.DisplayMessage("Adding sugar and milk");
        }

        protected override void Brew()
        {
            view.DisplayMessage("Dripping coffee through filter");
        }
    }
}
