using Common.Interfaces;
using StatePattern.Context;
using StatePattern.State;

namespace StatePattern.ConcreteStates
{
    public class SoldOutState : IState
    {
        private readonly IView view;

        public SoldOutState(IView view)
        {
            this.view = view;
        }

        public void Dispense()
        {
            view.DisplayMessage("No gumball to dispense");
        }

        public void EjectQuarter()
        {
            view.DisplayMessage("You can't eject, you haven't inserted a quarter yet.");
        }

        public void InsertQuarter()
        {
            view.DisplayMessage("You can't insert a quarter, the machine is sold out.");
        }

        public void TurnCrank()
        {
            view.DisplayMessage("You turned, but there are no gumballs.");
        }
    }
}
