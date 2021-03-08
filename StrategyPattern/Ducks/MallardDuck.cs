using Common.Interfaces;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Ducks
{
    // a Mallard duck IS-A duck
    public class MallardDuck : Duck
    {
        public MallardDuck(IFlyBehavior fly, IQuackBehavior quack, IView view) : base(fly, quack, view)
        {

        }

        public override void DisplayDuckMessage()
        {
            view.DisplayMessage("I'm a real Mallard duck. Duck you!!");
        }
    }
}
