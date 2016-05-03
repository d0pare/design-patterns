using System;

namespace RemoteControl.Receivers
{
    public class CeilingFan
    {
        private readonly string _location;
        private int _level;

        public const int HIGH = 2;
        public const int MEDIUM = 1;
        public const int LOW = 0;

        public CeilingFan(string location)
        {
            _location = location;
        }

        public void High()
        {
            // turns the ceiling fan on to high
            _level = HIGH;
            Console.WriteLine(_location + " ceiling fan is on high");
        }

        public void Medium()
        {
            // turns the ceiling fan on to medium
            _level = MEDIUM;
            Console.WriteLine(_location + " ceiling fan is on medium");
        }

        public void Low()
        {
            // turns the ceiling fan on to low
            _level = LOW;
            Console.WriteLine(_location + " ceiling fan is on low");
        }

        public void Off()
        {
            // turns the ceiling fan off
            _level = 0;
            Console.WriteLine(_location + " ceiling fan is off");
        }

        public int GetSpeed() => _level;
    }
}