using Common.Interfaces;
using StatePattern.ConcreteStates;
using StatePattern.State;
using System;

namespace StatePattern.Context
{
    public class GumballMachine
    {
        private readonly IState soldOutState;
        private readonly IState noQuarterState;
        private readonly IState hasQuarterState;
        private readonly IState soldState;
        private readonly IView view;

        private IState state;
        private int count = 0;

        public GumballMachine(int numberOfGumballs, IView view)
        {
            soldOutState = new SoldOutState(view, this);
            state = soldOutState;
            noQuarterState = new NoQuarterState(view, this);
            hasQuarterState = new HasQuarterState(view, this);
            soldState = new SoldState(view, this);

            this.view = view;

            count = numberOfGumballs;

            if(numberOfGumballs > 0)
            {
                state = noQuarterState;
            }
        }

        internal IState GetSoldOutState()
        {
            return soldOutState;
        }

        internal int GetCount()
        {
            return count;
        }

        internal IState GetHasQuarterState()
        {
            return hasQuarterState;
        }

        internal IState GetSoldState()
        {
            return soldState;
        }

        internal IState GetNoQuarterState()
        {
            return noQuarterState;
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void ReleaseBall()
        {
            view.DisplayMessage("A gumball comes rolling out the slot...");
            if(count > 0)
            {
                count--;
            }
        }
    }
}
