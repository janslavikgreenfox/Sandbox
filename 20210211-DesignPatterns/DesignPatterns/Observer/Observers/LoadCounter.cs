using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class LoadCounter : IObserver
    {
        public AccelerometerSensor AccelerometerSensor { get; private set; }
        public LoadCounter(AccelerometerSensor accelerometerSensor)
        {
            this.AccelerometerSensor = accelerometerSensor;
        }
        public void Update()
        {
            var acc = AccelerometerSensor.getState();
            if (acc[2] > 4)
            {
                // save load threshold crossing event
            }
            Console.WriteLine("The load has been saved in the Load Counter.");
        }
    }
}
