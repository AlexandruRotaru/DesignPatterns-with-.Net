using Common.Interfaces;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class Duck
    {
        // a duck HAS-A flying behavior and a quack behavior
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        // a duck HAS-A way of "communicating" with the outside
        protected readonly IView view;
       
        public Duck(IFlyBehavior fly, IQuackBehavior quack, IView view)
        {
            flyBehavior = fly;
            quackBehavior = quack;
            this.view = view;
        }

        public void SetFlyBehavior(IFlyBehavior fly)
        {
            flyBehavior = fly;
        }

        public void SetQuackBehavior(IQuackBehavior quack)
        {
            quackBehavior = quack;
        }

        public void PerformQuack()
        {
            quackBehavior.Quack(view);
        }

        public void PerformFly()
        {
            flyBehavior.Fly(view);
        }

        public virtual void Swim()
        {
            view.DisplayMessage("I'ma swimming. YAAYYYY!!!");
        }

        public virtual void DisplayDuckMessage()
        {
            view.DisplayMessage("I'ma DUCK!!!");
        }
    }
}
