using System;
using WeatherStation.Observable.Subjects;

namespace WeatherStation.Observable.Observers
{
    public class ForecastDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private double _currentPressure = 29.92d;
        private double _lastPressure;
        private readonly IDisposable _unsubscriber;

        public ForecastDisplay(IObservable<WeatherData> weatherData)
        {
            if (weatherData != null)
                _unsubscriber = weatherData.Subscribe(this);
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

        public void OnCompleted()
        {
            Console.WriteLine("Weather station has completed transmitting data");
            _unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error occured {0}", error);
        }

        public void OnNext(WeatherData value)
        {
            _lastPressure = _currentPressure;
            _currentPressure = value.Pressure;

            Display();
        }
    }
}
