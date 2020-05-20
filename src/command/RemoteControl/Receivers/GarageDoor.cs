using System;

namespace RemoteControl.Receivers
{
    public class GarageDoor
    {
        private readonly string _location;

        public GarageDoor(string location)
        {
            _location = location;
        }

        public void Up() => Console.WriteLine(_location + " garage Door is Open");

        public void Down() => Console.WriteLine(_location + " garage Door is Closed");

        public void Stop() => Console.WriteLine(_location + " garage Door is Stopped");

        public void LightOn() => Console.WriteLine(_location + " garage light is on");

        public void LightOff() => Console.WriteLine(_location + " garage light is off");
    }
}