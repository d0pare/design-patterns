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
            var lightOff = new LightOffCommand(light);
            var garageOpen = new GarageDoorOpenCommand(garageDoor);
            var garageClose = new GarageDoorCloseCommand(garageDoor);
            var garageStop = new GarageDoorStopCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            remote.SetCommand(lightOff);
            remote.ButtonWasPressed();

            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();

            remote.SetCommand(garageClose);
            remote.ButtonWasPressed();

            remote.SetCommand(garageStop);
            remote.ButtonWasPressed();

            Console.ReadKey();
        }
    }
}
