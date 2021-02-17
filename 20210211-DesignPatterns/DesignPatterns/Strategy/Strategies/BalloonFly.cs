using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    class BalloonFly : IFlyStrategy
    {
        public double MaximalLoad(double mass, double stallSpeed, double designSpeed, double liftCoefficient)
        {
            var rho = 1.125;
            var rho0 = 0.949; // air at 90 deg C
            return (rho - rho0) * stallSpeed / mass - 1;
        }
    }
}
