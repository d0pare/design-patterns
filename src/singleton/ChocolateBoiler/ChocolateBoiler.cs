using System;
using System.Reflection;

namespace ChocolateBoiler
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler _uniqueInstance;

        public static ChocolateBoiler Instance
        {
            get
            {
                if (_uniqueInstance == null)
                {
                    Console.WriteLine("Creating unique instance of Chocolate Boiler");
                    _uniqueInstance = new ChocolateBoiler();
                }
                else _uniqueInstance.WriteBoiler(MethodBase.GetCurrentMethod().Name);

                Console.WriteLine("Returning instance of Chocolate Boiler");
                return _uniqueInstance;
            }
        }

        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
            WriteBoiler(MethodBase.GetCurrentMethod().Name);
        }

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
            WriteBoiler(MethodBase.GetCurrentMethod().Name);
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                // drain the boiled milk and chocolate
                Empty = true;
            }
            WriteBoiler(MethodBase.GetCurrentMethod().Name);
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                // bring the contents to a boil
                Boiled = true;             
            }
            WriteBoiler(MethodBase.GetCurrentMethod().Name);
        }

        private void WriteBoiler(string caller)
        {
            Console.WriteLine("After: {0,-30} Empty: {1,-10}, Boiled: {2,-10}", caller, Empty, Boiled);
        }
    }
}
