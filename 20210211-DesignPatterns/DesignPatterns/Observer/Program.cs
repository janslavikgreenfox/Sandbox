using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var accSensor = new AccelerometerSensor();

            var hud = new HUD(accSensor);
            accSensor.Add(hud);

            var glassCkpt = new GlassCokpitMainScreen(accSensor);
            accSensor.Add(glassCkpt);

            var loadCounter = new LoadCounter(accSensor);
            accSensor.Add(loadCounter);

            accSensor.setState(new double[] { 0.001, 0.00, 9.991 });
            accSensor.setState(new double[] { 0.001, 0.00, 9.991 });
            accSensor.setState(new double[] { 0.001, 0.00, 9.981 });
            accSensor.setState(new double[] { 0.001, 0.00, 9.900 });
            accSensor.setState(new double[] { 0.001, 0.00, 9.950 });
            accSensor.Notify();
        }
    }
}
