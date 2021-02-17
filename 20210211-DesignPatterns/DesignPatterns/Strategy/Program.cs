using System;
using Strategy.Strategies;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AircraftContext airplane = new AircraftContext(new AirplaneFly());
            AircraftContext balloon = new AircraftContext(new BalloonFly());

            Console.WriteLine($"Return aircraft maximal load {airplane.GetMaximalLoad()}");
            Console.WriteLine($"Return balloon maximal load {balloon.GetMaximalLoad()}");
        }
    }
}
