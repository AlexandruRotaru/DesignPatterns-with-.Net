using Common.Interfaces;
using StatePattern.Context;
using StatePattern.State;

namespace StatePattern.ConcreteStates
{
    public class HasQuarterState : IState
    {
        private readonly IView view;
        private readonly GumballMachine gumballMachine;

        public HasQuarterState(IView view, GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
            this.view = view;
        }

        public void Dispense()
        {
            view.DisplayMessage("No gumball dispensed.");
        }

        public void EjectQuarter()
        {
            view.DisplayMessage("Quarter returned.");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            view.DisplayMessage("You can't insert another quarter.");
        }

        public void TurnCrank()
        {
            view.DisplayMessage("You turned...");
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }
    }
}
