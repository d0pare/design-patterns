using System;
using SimpleRemoteControl.Commands;
using SimpleRemoteControl.Receivers;

namespace SimpleRemoteControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var remote = new Invokers.SimpleRemoteControl();

            var light = new Light();
            var garageDoor = new GarageDoor();

            var lightOn = new LightOnCommand(light);
            var garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
        }
    }
}
