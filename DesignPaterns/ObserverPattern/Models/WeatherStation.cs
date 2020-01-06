using DesignPaterns.ObserverPattern.Interface;
using System;
using System.Collections.Generic;

namespace DesignPaterns.ObserverPattern.Models
{
    public class WeatherStation : IObservable
    {
        private int Tempature { get;  set; }
        public List<IObserver> observer { get; set; }
   
        public void Add(IObserver _observer)
        {
            this.observer.Add(_observer);
        }

        public void Notify(int i)
        {
            foreach (IObserver item in this.observer)
            {
               item.Update(i);
            }
        }

        public void Remove(IObserver observer)
        {
            this.observer.Remove(observer);
        }

        public int GetTempature(int i)
        {
            Tempature = Tempature + i;
            return this.Tempature;
        }
    }
}
