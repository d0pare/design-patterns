using System;

namespace HomeTheater
{
    public class TheaterLights
    {
        private readonly string _description;

        public TheaterLights(string description)
        {
            _description = description;
        }

        public void On()
        {
            Console.WriteLine($"{_description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{_description} off");
        }

        public void Dim(int level)
        {
            Console.WriteLine($"{_description} dimming to {level.ToString()}%");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}