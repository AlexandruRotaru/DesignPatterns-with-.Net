using Common.Interfaces;
using StatePattern.Context;
using StatePattern.State;

namespace StatePattern.ConcreteStates
{
    public class SoldState : IState
    {
        private readonly IView view;
        private readonly GumballMachine gumballMachine;

        public SoldState(IView view, GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
            this.view = view;
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();

            if(gumballMachine.GetCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            }
            else
            {
                view.DisplayMessage("Oops, out of gumballs.");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
        }

        public void EjectQuarter()
        {
            view.DisplayMessage("Sorry, ou already turned the crank.");
        }

        public void InsertQuarter()
        {
            view.DisplayMessage("Please wait, we're already giving you a gumball.");
        }

        public void TurnCrank()
        {
            view.DisplayMessage("Turning twice doesn't give you another gumball!!!");
        }
    }
}
