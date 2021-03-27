using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Visitables;

namespace Visitor.Visitors
{
    class ThrustToWeightRatio : IVisitor
    {
        public double Visit(Baloon baloon)
        {
            const double RHO = 0.8;
            const double G_0 = 9.80665;
            return baloon.VolumeOfHotAir*RHO*G_0/baloon.Mass;
        }

        public double Visit(Drone drone)
        {
            return drone.Thrust/drone.Mass;
        }

        public double Visit(Airplane airplane)
        {
            return airplane.Thrust/airplane.Mass;
        }
    }
}
