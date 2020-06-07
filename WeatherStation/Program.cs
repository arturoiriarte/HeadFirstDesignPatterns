using System;
using WeatherStation.Displays;
using WeatherStation.Subject;

namespace WeatherStation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Subject
            WeatherData data = new WeatherData();

            //Observer
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(data);

            data.setMeasurements(80, 65, 30.4f);
            data.setMeasurements(82, 70, 29.2f);
            data.setMeasurements(78, 90, 30.1f);
        }
    }
}
