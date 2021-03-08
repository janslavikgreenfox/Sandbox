using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class AccelerometerSensor : ISubject
    {
        public  double[] CurrentValue { get; private set; }
        private List<IObserver> Observers { get; set; }

        public AccelerometerSensor()
        {
            this.CurrentValue = new double[] { 0.0, 0.0, 1.0 };
            this.Observers = new List<IObserver>();
        }
        public void Add(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void Notify()
        {
            foreach(var observer in Observers)
            {
                observer.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void setState(double[] setValue)
        {
            this.CurrentValue = setValue;
        }
        public double[] getState()
        {
            return CurrentValue;
        }
    }
}
