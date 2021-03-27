using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Visitors;

namespace Visitor.Visitables
{
    class Drone : IVisitable
    {
        public int Mass { get; set; }
        public double Velocity { get; set; }
        public double Thrust { get; set; }
        public Drone(int mass, double velocity, double thrust)
        {
            Mass = mass;
            Velocity = velocity;
            Thrust = thrust;
        }
        
        public double Accept(IVisitor visitor)
        {
            Console.WriteLine("Drone class - Accept method");
            return visitor.Visit(this);
        }
    }
}
