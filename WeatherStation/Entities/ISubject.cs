using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.Entities
{
    public interface ISubject
    {
        public void registerObserver(IObserver observer);
        public void removeObserver(IObserver observer);
        public void notifyObservers();
    }
}
