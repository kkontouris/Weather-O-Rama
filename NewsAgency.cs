using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_O_Rama
{
    public class NewsAgency : IObserver
    {
        private float temperature;
        private float humidity;
        private string name;
        private ISubject weatherstation;

        public NewsAgency(string name)
        {
            this.name = name;
        }
        public NewsAgency(ISubject weatherstation)
        {
            this.weatherstation = weatherstation;
           // weatherstation.attachObserver(this);
        }

        public void Update(float temp, float humid)
        {
            this.temperature = temp;
            this.humidity = humid;
            Console.WriteLine($"The name of the agency is {name} and the temperature of today is {temperature} and the humidity is {humidity}");
        }
    }

    public class RealNews : IObserver
    {
        private float temperature;
        private float humidity;
        private string name;
        private ISubject weatherstation;

        public RealNews(string name)
        {
            this.name = name;
        }
        public RealNews(ISubject weatherstation)
        {
            this.weatherstation = weatherstation;
            //weatherstation.attachObserver(this);
        }

        public void Update(float temp, float humid)
        {
            this.temperature = temp;
            this.humidity = humid;
            Console.WriteLine($"The name of the agency is {name} and the temperature of today is {temperature} and the humidity is {humidity}");
        }
    }

}
