using System;
using Visitor.Visitables;
using Visitor.Visitors;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var thrustToWeight = new ThrustToWeightRatio();

            var airplane = new Airplane(16000,1250000);
            var baloon = new Baloon(1500,25000);
            var drone = new Drone(7, 100, 10);

            var airplaneT2W = airplane.Accept(thrustToWeight);
            var baloonT2W = baloon.Accept(thrustToWeight);
            var droneT2W = drone.Accept(thrustToWeight);
        }
    }
}
