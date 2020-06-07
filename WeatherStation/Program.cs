using System;
using WeatherStation.Displays;
using WeatherStation.Entities;
using WeatherStation.Subject;

namespace WeatherStation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Subject
            WeatherProvider data = new WeatherProvider();

            //Observer
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            forecastDisplay.Subscribe(data);

            data.SetMeasurements(new WeatherModel{ Temperature = 95, Humidity = 65, Pressure = 30.4f });
            currentConditionsDisplay.Subscribe(data);
            data.SetMeasurements(new WeatherModel { Temperature = 82, Humidity = 70, Pressure = 29.2f });
            currentConditionsDisplay.Unsubscribe();
            data.SetMeasurements(new WeatherModel { Temperature = 32, Humidity = 90, Pressure = 30.1f });

            data.EndTransmission();
            Console.WriteLine("<<Stop transmission>>");
            data.SetMeasurements(new WeatherModel { Temperature = 32, Humidity = 90, Pressure = 30.1f });
        }
    }
}
