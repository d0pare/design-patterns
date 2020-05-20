using System;

namespace Barista
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool CustomerWantsCondiments => GetUserInput().ToUpper().StartsWith("Y");

        private string GetUserInput()
        {
            Console.WriteLine("Would you like lemon with your tea (y/n)? ");

            string answer = Console.ReadLine();

            return answer ?? "no";
        }
    }
}