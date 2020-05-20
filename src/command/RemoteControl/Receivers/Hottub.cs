using System;

namespace RemoteControl.Receivers
{
    public class Hottub
    {
        private bool _on;
        private int _temperature;

        public void On() => _on = true;

        public void Off() => _on = false;

        public void BubblesOn()
        {
            if (_on)
            {
                Console.WriteLine("Hottub is bubbling!");
            }
        }

        public void BubblesOff()
        {
            if (_on)
            {
                Console.WriteLine("Hottub is not bubbling!");
            }
        }

        public void JetsOn()
        {
            if (_on)
            {
                Console.WriteLine("Hottub jets are on");
            }
        }

        public void JetsOff()
        {
            if (_on)
            {
                Console.WriteLine("Hottub jets are off");
            }
        }

        public void SetTemperature(int temperature) => _temperature = temperature;

        public void Heat()
        {
            _temperature = 105;
            Console.WriteLine("Hottub is heating to a steaming 105 degrees");
        }

        public void Cool()
        {
            _temperature = 98;
            Console.WriteLine("Hottub is cooling to 98 degrees");
        }
    }
}