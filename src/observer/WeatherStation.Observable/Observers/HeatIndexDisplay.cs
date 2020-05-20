using System;
using WeatherStation.Observable.Subjects;

namespace WeatherStation.Observable.Observers
{
    public class HeatIndexDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private double _heatIndex;
        private readonly IDisposable _unsubscriber;

        public HeatIndexDisplay(IObservable<WeatherData> weatherData)
        {
            if (weatherData != null)
                _unsubscriber = weatherData.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine("Heat index is " + _heatIndex);
        }

        private double ComputeHeatIndex(double t, double rh)
        {
            double index = (16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
                            + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh))
                            + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                            (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                            (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                            (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                            0.000000000843296 * (t * t * rh * rh * rh)) -
                           (0.0000000000481975 * (t * t * t * rh * rh * rh));
            return index;
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
            _heatIndex = ComputeHeatIndex(value.Temperature, value.Humidity);
            Display();
        }
    }
}
