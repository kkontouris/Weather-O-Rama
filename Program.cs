using System;

namespace Weather_O_Rama
{
    public class Program
    {
        public static void Main(string[] args)
        {
             WeatherStation station = new WeatherStation();

            NewsAgency agency1 = new NewsAgency(station);         
            RealNews realNews= new RealNews(station);
            NewsAgency agency2 = new NewsAgency(station);


            station.SetMeasurements(34, 64);
            station.SetMeasurements(23, 70);



        }
    }
}