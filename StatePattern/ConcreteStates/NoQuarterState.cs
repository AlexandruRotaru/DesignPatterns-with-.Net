using Common.Interfaces;
using StatePattern.Context;
using StatePattern.State;

namespace StatePattern.ConcreteStates
{
    public class NoQuarterState : IState
    {
        private readonly IView view;
        private readonly GumballMachine gumballMachine;

        public NoQuarterState(IView view, GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
            this.view = view;
        }

        public void Dispense()
        {
            view.DisplayMessage("You need to pay first.");           
        }

        public void EjectQuarter()
        {
            view.DisplayMessage("You haven't inserted a quarter.");
        }

        public void InsertQuarter()
        {
            view.DisplayMessage("You inserted a quarter.");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());           
        }

        public void TurnCrank()
        {
            view.DisplayMessage("You turned, but there's no quarter quarter.");
        }
    }
}
