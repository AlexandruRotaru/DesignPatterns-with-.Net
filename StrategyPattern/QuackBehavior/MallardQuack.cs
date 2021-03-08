using Common.Interfaces;
using StrategyPattern.Interfaces;

namespace StrategyPattern.QuackBehavior
{
    public class MallardQuack : IQuackBehavior
    {
        public void Quack(IView view)
        {
            view.DisplayMessage("Quack like a mallard duck.");
        }
    }
}
