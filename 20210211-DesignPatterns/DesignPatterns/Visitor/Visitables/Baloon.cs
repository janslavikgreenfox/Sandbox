using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Visitors;

namespace Visitor.Visitables
{
    class Baloon : IVisitable
    {
        public int Mass { get; set; }
        public double VolumeOfHotAir { get; set; }
        public Baloon(int mass, double volumeOfHotAir)
        {
            Mass = mass;
            VolumeOfHotAir = volumeOfHotAir;
        }

        public double Accept(IVisitor visitor)
        {
            Console.WriteLine("Baloon class - Accept method");
            return visitor.Visit(this);
        }
    }
}
