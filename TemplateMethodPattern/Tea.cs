using Common.Interfaces;

namespace TemplateMethodPattern
{
    public class Tea : CaffeineBeverage
    {
        public Tea(IView view)
        {
            this.view = view;
        }

        protected override void AddCondiments()
        {
            view.DisplayMessage("Adding Lemon");
        }

        protected override void Brew()
        {
            view.DisplayMessage("Steeping the tea");
        }
    }
}
