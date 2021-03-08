using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class HUD : IObserver
    {
        public AccelerometerSensor AccelerometerSensor { get; private set; }
        public HUD(AccelerometerSensor accelerometerSensor)
        {
            this.AccelerometerSensor = accelerometerSensor;
        }
        void IObserver.Update()
        {
            Display(AccelerometerSensor.getState()[2] / 9.81 / 4000);
            Console.WriteLine("The HUD is updating ... done.");
        }
        private void Display(double nz)
        {
            Console.WriteLine($"HUD nz = {nz}" );
        }
    }
}
