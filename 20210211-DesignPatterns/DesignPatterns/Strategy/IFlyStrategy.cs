using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    interface IFlyStrategy
    {
        double MaximalLoad(double mass, double stallSpeed, double designSpeed, double liftCoefficient);
    }
}
