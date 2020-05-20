using System;
using WeatherStation.Subjects;

namespace WeatherStation.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _currentPressure = 29.92d;
        private double _lastPressure;
        private readonly ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;

            Display();
        }
    }
}
