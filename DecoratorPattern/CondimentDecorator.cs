namespace DecoratorPattern
{
    // as per decorator patterns, it needs to be interchangeable with a Beverage
    // so it inherits it
    public abstract class CondimentDecorator : Beverage
    {
        // it's abstract to force the concrete decorators to implement it
        public override abstract string GetDescription();
    }
}
