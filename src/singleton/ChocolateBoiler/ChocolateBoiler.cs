using System;

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
        }

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (!Empty && !Boiled)
            {
                // drain the boiled milk and chocolate
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                // bring the contents to a boil
                Boiled = true;
            }
        }
    }
}