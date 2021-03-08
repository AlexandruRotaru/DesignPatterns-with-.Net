using Common.Interfaces;

namespace StrategyPattern.Interfaces
{
    // Identify and separate what can vary from what stays the same.
    // In this case FlyBehavior and QuackBehavior
    public interface IFlyBehavior
    {
        public void Fly(IView view);
    }
}
