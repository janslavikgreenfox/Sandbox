using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    class AirplaneFly : IFlyStrategy
    {
        public double MaximalLoad(double mass, double stallSpeed, double designSpeed, double liftCoefficient)
        {
            var rho = 1.119;
            var g0 = 9.80665;
            return liftCoefficient*(1/2*rho*designSpeed*designSpeed)/(mass*g0);
        }
    }
}
