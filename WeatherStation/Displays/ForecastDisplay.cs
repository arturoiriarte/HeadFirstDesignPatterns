using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Entities;

namespace WeatherStation.Displays
{
    public class ForecastDisplay : IObserver<WeatherModel>, IDisplay
    {
        private IDisposable unsubscriber;

        public void Display(WeatherModel model)
        {
            if (model.Temperature > 90)
                Console.WriteLine("Stay home, it's hot outside");
            else if (model.Temperature <= 32)
                Console.WriteLine($"It's freezing!!");
            else
                Console.WriteLine("Nice sunny day");
        }

        public void OnCompleted()
        {
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Forecast Unknown error");
        }

        public void OnNext(WeatherModel value)
        {
            Display(value);
        }

        public virtual void Subscribe(IObservable<WeatherModel> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
