using Common.Interfaces;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private readonly IView view;
        private readonly ISubject weatherData;

        private float temperature;
        private float humidity;
        private float pressure;

        public CurrentConditionsDisplay(IView view, ISubject weatherData)
        {
            this.view = view;
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            string currentConditions = $"Current conditions: {temperature} degrees with {humidity} % humidity and {pressure} pressure";
            view.DisplayMessage(currentConditions);
        }

        public void Unregister()
        {
            weatherData.RemoveObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
