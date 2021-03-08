using Common.Interfaces;
using IteratorPattern.Aggregator;
using IteratorPattern.Iterator;

namespace IteratorPattern
{
    public class Waitress
    {
        private readonly IMenu pancakeHouseMenu;
        private readonly IMenu dinerMenu;
        private readonly IView view;
        private MenuItem menuItem;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IView view)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            this.view = view;
        }

        public void PrintMenu()
        {
            IMenuIterator<MenuItem> pancakeIterator = pancakeHouseMenu.CreateIterator();
            IMenuIterator<MenuItem> dinerIterator = dinerMenu.CreateIterator();

            view.DisplayMessage("MENU\n-------\nBREAKFAST");
            PrintMenu(pancakeIterator);
            view.DisplayMessage("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IMenuIterator<MenuItem> iterator)
        {           
            while (iterator.HasNext())
            {
                menuItem = iterator.Next();

                view.DisplayMessage($"{menuItem.GetName()} ,");
                view.DisplayMessage($"{menuItem.GetPrice()} ,");
                view.DisplayMessage($"{menuItem.GetDescription()} ,");
            }
        }
    }
}
