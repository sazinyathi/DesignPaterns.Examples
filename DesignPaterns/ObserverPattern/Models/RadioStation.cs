using DesignPaterns.ObserverPattern.Interface;
using System;

namespace DesignPaterns.ObserverPattern.Models
{
    public class RadioStation : IObserver
    {
        public WeatherStation _weather { get; set; }
        public RadioStation(WeatherStation weather)
        {
            this._weather = weather;
        }
        public void Update(int i)
        {
           Console.WriteLine("New Tempature measured in previsous 2 seconds {0}",_weather.GetTempature(i));
        }

       

    }
}
