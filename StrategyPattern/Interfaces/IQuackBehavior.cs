using Common.Interfaces;

namespace StrategyPattern.Interfaces
{
    public interface IQuackBehavior
    {
        public void Quack(IView view);
    }
}
