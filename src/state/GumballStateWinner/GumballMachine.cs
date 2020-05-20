using System;
using System.Text;
using GumballStateWinner.States;

namespace GumballStateWinner
{
    //Context
    public class GumballMachine
    {
        public GumballMachine(int numberGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            Count = numberGumballs;

            State = numberGumballs > 0 ? NoQuarterState : SoldOutState;
        }

        public int Count { get; private set; }
        public IState State { get; private set; }

        public IState SoldOutState { get; }
        public IState NoQuarterState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; }
        public IState WinnerState { get; }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }

        public void Refill(int count)
        {
            Count += count;
            Console.WriteLine($"The gumball machine was just refilled; it's new count is: {Count.ToString()}");
            State.Refill();
        }

        public void SetState(IState state)
        {
            State = state;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nC#-enabled Standing Gumball Model #2016");
            result.Append("\nInventory: " + Count.ToString() + " gumball");
            if (Count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + State + "\n");

            return result.ToString();
        }
    }
}