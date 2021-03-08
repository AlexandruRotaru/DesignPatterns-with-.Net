using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);

        public void Unregister();
    }
}
