namespace DecoratorPattern.ConcreteComponents
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend Cofee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
