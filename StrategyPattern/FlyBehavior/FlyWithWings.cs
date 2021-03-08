using Common.Interfaces;
using StrategyPattern.Interfaces;


namespace StrategyPattern.FlyBehavior
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly(IView view)
        {
            view.DisplayMessage("Flapp whe wings and fly!");
        }
    }
}
