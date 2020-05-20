using System;

namespace Party.Receivers
{
    public class Hottub
    {
        private bool _on;
        private int _temperature;

        public void On() => _on = true;

        public void Off() => _on = false;

        public void Circulate()
        {
            if (_on)
            {
                Console.WriteLine("Hottub is bubbling!");
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

        public void SetTemperature(int temperature)
        {
            if (temperature > _temperature)
            {
                Console.WriteLine("Hottub is heating to a steaming " + temperature + " degrees");
            }
            else
            {
                Console.WriteLine("Hottub is cooling to " + temperature + " degrees");
            }
            _temperature = temperature;
        }
    }
}