namespace ObserverPattern.Basic;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers = [];

    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double Pressure { get; set; }

    public void RegisterObserver(IObserver observer)
    {
        if (!_observers.Contains(observer)) _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        if (_observers.Contains(observer)) _observers.Add(observer);
    }

    public void NotifyObserver()
    {
        if (_observers.Count == 0) return;

        _observers.ForEach(o => o.Update(Temperature, Humidity, Pressure));
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;

        MeasurementsChanged();
    }

    /// <summary>
    ///     Update the measurement of weather units
    /// </summary>
    public void MeasurementsChanged()
    {
        NotifyObserver();
    }
}