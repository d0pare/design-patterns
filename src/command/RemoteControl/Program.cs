using System;
using RemoteControl.Commands;
using RemoteControl.Receivers;

namespace RemoteControl
{
    public class Program
    {
        const int LIVING_ROOM = 0;
        const int KITCHEN_LIGHT = 1;
        const int CEILING_FAN = 2;
        const int STEREO = 3;
        const int GARAGE_DOOR = 4;

        public static void Main(string[] args)
        {
            var remoteControl = new Invokers.RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(LIVING_ROOM, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(KITCHEN_LIGHT, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(CEILING_FAN, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(STEREO, stereoOnWithCD, stereoOff);
            remoteControl.SetCommand(GARAGE_DOOR, garageDoorUp, garageDoorDown);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(LIVING_ROOM);
            remoteControl.OffButtonWasPushed(LIVING_ROOM);
            remoteControl.OnButtonWasPushed(KITCHEN_LIGHT);
            remoteControl.OffButtonWasPushed(KITCHEN_LIGHT);
            remoteControl.OnButtonWasPushed(CEILING_FAN);
            remoteControl.OffButtonWasPushed(CEILING_FAN);
            remoteControl.OnButtonWasPushed(STEREO);
            remoteControl.OffButtonWasPushed(STEREO);
            remoteControl.OnButtonWasPushed(GARAGE_DOOR);
            remoteControl.OffButtonWasPushed(GARAGE_DOOR);

            Console.ReadKey();
        }
    }
}
