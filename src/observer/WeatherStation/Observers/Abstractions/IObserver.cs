namespace WeatherStation.Observers
{
    public interface IObserver
    {
        void Update(double temp, double humidity, double pressure);
    }
}
