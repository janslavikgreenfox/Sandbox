using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Visitors;

namespace Visitor.Visitables
{
    class Airplane : IVisitable
    {
        public int Mass { get; set; }
        public double Thrust { get; set; }
        public Airplane(int mass, double thrust)
        {
            Mass = mass;
            Thrust = thrust;
        }

        public double Accept(IVisitor visitor)
        {
            Console.WriteLine("Airplane class - Accept method");
            return visitor.Visit(this);
        }
    }
}
