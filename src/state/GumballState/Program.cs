using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GumballState
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(2);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.Refill(5);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
        }
    }
}
