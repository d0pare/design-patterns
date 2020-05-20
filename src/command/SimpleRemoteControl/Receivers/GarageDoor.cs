using System;

namespace SimpleRemoteControl.Receivers
{
    public class GarageDoor
    {
        public void Up() => Console.WriteLine("Garage Door is Open");

        public void Down() => Console.WriteLine("Garage Door is Closed");

        public void Stop() => Console.WriteLine("Garage Door is Stopped");

        public void LightOn() => Console.WriteLine("Garage light is on");

        public void LightOff() => Console.WriteLine("Garage light is off");
    }
}