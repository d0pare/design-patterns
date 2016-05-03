using System;

namespace RemoteControl.Receivers
{
    public class Stereo
    {
        private readonly string _location;

        public Stereo(string location)
        {
            _location = location;
        }

        public void On() => Console.WriteLine(_location + " stereo is on");

        public void Off() => Console.WriteLine(_location + " stereo is off");

        public void SetCD() => Console.WriteLine(_location + " stereo is set for CD input");

        public void SetDVD() => Console.WriteLine(_location + " stereo is set for DVD input");

        public void SetRadio() => Console.WriteLine(_location + " stereo is set for Radio");

        public void SetVolume(int volume) => Console.WriteLine(_location + " stereo volume set to " + volume);
    }
}