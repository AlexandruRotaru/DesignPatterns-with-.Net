using StrategyPattern;

namespace DesignPatternsApplied
{
    public class MiniDuckSimulator
    {
        private Duck duck;

        public MiniDuckSimulator(Duck duck)
        {
            this.duck = duck;
        }

        public void SetDuck(Duck duck)
        {
            this.duck = duck;
        }

        public void Run()
        {
            duck.DisplayDuckMessage();
            duck.PerformFly();
            duck.PerformQuack();
            duck.Swim();
        }
        
    }
}
