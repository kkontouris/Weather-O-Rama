using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_O_Rama
{
    public class WeatherStation : ISubject
    {
        private float temperature;
        private float humidity;
        
        private List<IObserver> observers;

        public WeatherStation()
        {
            observers = new List<IObserver>();
        }

        public void attachObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void notifyObservers()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(temperature,humidity);
                              
            }
        }
        public void SetMeasurements(float temperature, float humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            measurementsChanged();

        }
        public void measurementsChanged()
        {
            notifyObservers();

        }
    }

}
