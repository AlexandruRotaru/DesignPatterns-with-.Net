using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern.Subject
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> observerList;
        private float temperature;
        private float humidity;
        private float pressure;

        public float Temperature 
        {
            set { temperature = value; MeasurementChanged(); } 
        }

        public float Humidity
        {
            set { humidity = value; MeasurementChanged(); }
        }

        public float Pressure
        {
            set { pressure = value; MeasurementChanged(); }
        }

        public WeatherData()
        {
            observerList = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(var observer in observerList)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if(observerList.Count > 0)
            {
                observerList.Remove(observer);
            }           
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementChanged();
        }
    }
}
