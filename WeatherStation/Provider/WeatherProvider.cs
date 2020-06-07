using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Entities;

namespace WeatherStation.Subject
{
    public class WeatherProvider : IObservable<WeatherModel>
    {
        private List<IObserver<WeatherModel>> observers;
        public WeatherProvider()
        {
            observers = new List<IObserver<WeatherModel>>();
        }

        public IDisposable Subscribe(IObserver<WeatherModel> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void SetMeasurements(WeatherModel weatherModel)
        {
            foreach (var observer in observers)
            {
                if (weatherModel == null)
                    observer.OnError(new Exception());
                else
                    observer.OnNext(weatherModel);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherModel>> observers;
            private IObserver<WeatherModel> observer;

            public Unsubscriber(List<IObserver<WeatherModel>> observers, IObserver<WeatherModel> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observer != null && observers.Contains(observer))
                    observers.Remove(observer);
            }
        }

    }

}
