using System;
using System.Globalization;

namespace HomeTheater
{
    public class Tuner
    {
        private readonly string _description;
        private readonly Amplifier _amplifier;
        private double _frequency;

        public Tuner(string description, Amplifier amplifier)
        {
            _description = description;
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine($"{_description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{_description} off");
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine($"{_description} setting frequency to {frequency.ToString(CultureInfo.InvariantCulture)}");
            _frequency = frequency;
        }

        public void SetAm()
        {
            Console.WriteLine($"{_description} setting AM mode");
        }

        public void SetFm()
        {
            Console.WriteLine($"{_description} setting FM mode");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}