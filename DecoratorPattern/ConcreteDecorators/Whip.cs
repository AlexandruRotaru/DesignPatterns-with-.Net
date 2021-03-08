namespace DecoratorPattern.ConcreteDecorators
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Whip(Beverage bev)
        {
            beverage = bev;
        }

        public override double Cost()
        {
            return 0.1 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}
