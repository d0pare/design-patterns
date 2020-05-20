using System;

namespace RemoteControl.Receivers
{
    public class TV
    {
        private string _location;
        private int _channel;

        public TV(string location)
        {
            _location = location;
        }

        public void On() => Console.WriteLine("TV is on");

        public void Off() => Console.WriteLine("TV is off");

        public void SetInputChannel()
        {
            _channel = 3;
            Console.WriteLine("Channel is set for VCR");
        }
    }
}