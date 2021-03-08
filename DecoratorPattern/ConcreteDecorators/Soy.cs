namespace DecoratorPattern.ConcreteDecorators
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Soy(Beverage bev)
        {
            beverage = bev;
        }

        public override double Cost()
        {
            return 0.31 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
