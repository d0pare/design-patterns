using System;

namespace HomeTheater
{
    public class Amplifier
    {
        private readonly string _description;

        public Amplifier(string description)
        {
            _description = description;
        }

        public Tuner Tuner { get; private set; }
        public DvdPlayer Dvd { get; private set; }
        public CdPlayer Cd { get; private set; }

        public void On()
        {
            Console.WriteLine($"{_description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{_description} off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine($"{_description} stereo mode on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine($"{_description} surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"{_description} setting volume to {level.ToString()}");
        }

        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine($"{_description} setting tunner to {tuner}");
            Tuner = tuner;
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine($"{_description} setting DVD player to {dvd}");
            Dvd = dvd;
        }

        public void SetCd(CdPlayer cd)
        {
            Console.WriteLine($"{_description} setting CD player to {cd}");
            Cd = cd;
        }

        public override string ToString()
        {
            return _description;
        }
    }
}