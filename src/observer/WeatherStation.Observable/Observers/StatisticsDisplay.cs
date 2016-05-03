using System;
using WeatherStation.Observable.Subjects;

namespace WeatherStation.Observable.Observers
{
    public class StatisticsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private double _maxTemp;
        private double _minTemp = 200;
        private double _tempSum;
        private int _numReadings;
        private readonly IDisposable _unsubscriber;

        public StatisticsDisplay(IObservable<WeatherData> weatherData)
        {
            if (weatherData != null)
                _unsubscriber = weatherData.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReadings)
            + "/" + _maxTemp + "/" + _minTemp);
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
            _tempSum += value.Temperature;
            _numReadings++;

            if (value.Temperature > _maxTemp)
            {
                _maxTemp = value.Temperature;
            }

            if (value.Temperature < _minTemp)
            {
                _minTemp = value.Temperature;
            }

            Display();
        }
    }
}
