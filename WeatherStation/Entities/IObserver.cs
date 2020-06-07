using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.Entities
{
    public interface IObserver
    {
        public void update(float temperature, float humidity, float pressure);
    }
}
