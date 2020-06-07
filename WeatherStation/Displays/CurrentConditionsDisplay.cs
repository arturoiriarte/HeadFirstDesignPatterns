﻿using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Entities;

namespace WeatherStation.Displays
{
    public class CurrentConditionsDisplay : IObserver<WeatherModel>, IDisplay
    {
        private IDisposable unsubscriber;

        public void Display(WeatherModel model)
        {
            Console.WriteLine($"Current conditions: {model.Temperature}F degrees and {model.Humidity}% humidity");
        }

        public void OnCompleted()
        {
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Current condition Unknown error");
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
