using DesignPaterns.ObserverPattern.Models;

namespace DesignPaterns.ObserverPattern.Service
{
    public class ObseverPatternService
    {
        private WeatherStation weatherStation;
        
        private RadioStation radioSatation;

        public WeatherStation WeatherStation
        {
            get
            {
                if (weatherStation == null)
                {
                    weatherStation = new WeatherStation();
                }
                return weatherStation;
            }
        }
        public RadioStation RadioStation
        {
            get
            {
                if(radioSatation == null)
                {
                    radioSatation = new RadioStation(WeatherStation);
                }
                return radioSatation;
            }
        }

        public void Execute(int i)
        {
            RadioStation.Update(i);
        }
    }
}
