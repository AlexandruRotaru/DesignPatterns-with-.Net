namespace DecoratorPattern.ConcreteDecorators
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Mocha(Beverage bev)
        {
            beverage = bev;
        }

        public override double Cost()
        {
            return 0.20 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
