using Common.Interfaces;
using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehavior
{
    public class NoFly : IFlyBehavior
    {
        public void Fly(IView view)
        {
            view.DisplayMessage("I can't fly!");
        }
    }
}
