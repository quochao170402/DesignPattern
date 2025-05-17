namespace ObserverPattern;

public class CurrentConditions : IObserver, IDisplay
{
    private double Temperature { get; set; }
    private double Humidity { get; set; }
    private double Pressure { get; set; }

    public void Update(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
    }

    public void Display()
    {
        Console.WriteLine($"- Temperature: {Temperature}\n- Humidity: {Humidity}\n- Pressure: {Pressure}");
    }
}

public class WeatherStats : IObserver, IDisplay
{
    private readonly List<double> _temperatureReadings = [];
    private readonly List<double> _humidityReadings = [];
    private readonly List<double> _pressureReadings = [];

    private double AvgTemperature => _temperatureReadings.Count != 0 ? _temperatureReadings.Average() : 0.0;
    private double MaxTemperature => _temperatureReadings.Count != 0 ? _temperatureReadings.Max() : 0.0;
    private double MinTemperature => _temperatureReadings.Count != 0 ? _temperatureReadings.Min() : 0.0;

    private double AvgHumidity => _humidityReadings.Count != 0 ? _humidityReadings.Average() : 0.0;
    private double AvgPressure => _pressureReadings.Count != 0 ? _pressureReadings.Average() : 0.0;



    public void Update(double temperature, double humidity, double pressure)
    {
        _temperatureReadings.Add(temperature);
        _humidityReadings.Add(humidity);
        _pressureReadings.Add(pressure);
    }

    public void Display()
    {
        Console.WriteLine("Weather Statistics:");
        Console.WriteLine($"Temperature - Avg: {AvgTemperature:F1}, Max: {MaxTemperature:F1}, Min: {MinTemperature:F1}");
        Console.WriteLine($"Humidity - Avg: {AvgHumidity:F1}");
        Console.WriteLine($"Pressure - Avg: {AvgPressure:F1}");
    }
}


public class Forecast : IObserver, IDisplay
{
    private double _previousPressure;
    private double _currentPressure;

    private string ForecastMessage { get; set; } = "No forecast available.";

    public void Update(double temperature, double humidity, double pressure)
    {
        _previousPressure = _currentPressure;
        _currentPressure = pressure;

        if (Math.Abs(_previousPressure) < 0.0001)
        {
            ForecastMessage = "Forecast initializing...";
        }
        else if (_currentPressure > _previousPressure)
        {
            ForecastMessage = "Improving weather on the way!";
        }
        else if (_currentPressure < _previousPressure)
        {
            ForecastMessage = "Watch out for cooler, rainy weather.";
        }
        else
        {
            ForecastMessage = "More of the same.";
        }
    }

    public void Display()
    {
        Console.WriteLine("Forecast:");
        Console.WriteLine(ForecastMessage);
    }
}

public class HeatIndex : IObserver, IDisplay
{
    private double _heatIndexCelsius;

    public void Update(double temperature, double humidity, double pressure)
    {
        // Store heat index in Celsius using formula based on Fahrenheit
        var T = temperature * 9 / 5 + 32; // Convert to Fahrenheit
        var R = humidity;

        // Heat index formula (U.S. National Weather Service)
        var HI_Fahrenheit = -42.379 + 2.04901523 * T + 10.14333127 * R
            - 0.22475541 * T * R - 0.00683783 * T * T
            - 0.05481717 * R * R + 0.00122874 * T * T * R
                                 + 0.00085282 * T * R * R - 0.00000199 * T * T * R * R;

        // Convert back to Celsius
        _heatIndexCelsius = (HI_Fahrenheit - 32) * 5 / 9;
    }

    public void Display()
    {
        Console.WriteLine($"Heat Index (Feels Like): {_heatIndexCelsius:F1} °C");
    }
}