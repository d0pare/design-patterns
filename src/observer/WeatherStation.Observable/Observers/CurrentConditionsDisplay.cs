using System;
using WeatherStation.Observable.Subjects;

namespace WeatherStation.Observable.Observers
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private readonly IDisposable _unsubscriber;

        public CurrentConditionsDisplay(IObservable<WeatherData> weatherData)
        {
            if(weatherData != null)
                _unsubscriber = weatherData.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
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
            _temperature = value.Temperature;
            _humidity = value.Humidity;
            Display();
        }
    }
}
