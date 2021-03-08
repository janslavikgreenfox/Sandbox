using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class GlassCokpitMainScreen : IObserver
    {
        public AccelerometerSensor AccelerometerSensor { get; private set; }
        public GlassCokpitMainScreen(AccelerometerSensor accelerometerSensor)
        {
            this.AccelerometerSensor = accelerometerSensor;
        }

        public void Update()
        {
            var acc = AccelerometerSensor.getState();
            Console.WriteLine($"The acceleration values are {acc[0]}, {acc[1]}, {acc[2]}");
            Console.WriteLine("The glass cockpit up-to-date."); 
        }
    }
}
