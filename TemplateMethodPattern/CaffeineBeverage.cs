using Common.Interfaces;
using System;

namespace TemplateMethodPattern
{
    public abstract class CaffeineBeverage
    {
        protected IView view;

        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void AddCondiments();
        protected abstract void Brew();

        private void PourInCup()
        {
            view.DisplayMessage("Pouring into cup");
        }

        private void BoilWater()
        {
            view.DisplayMessage("Boiling water");
        }
    }
}
