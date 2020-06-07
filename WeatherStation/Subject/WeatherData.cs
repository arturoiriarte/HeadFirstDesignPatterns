using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Entities;

namespace WeatherStation.Subject
{
    public class WeatherData : ISubject
    {
        private ICollection<IObserver> Observers { get; set; }
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public void notifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void measurementsChanged() { 
            notifyObservers(); 
        }

        //for testing
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
