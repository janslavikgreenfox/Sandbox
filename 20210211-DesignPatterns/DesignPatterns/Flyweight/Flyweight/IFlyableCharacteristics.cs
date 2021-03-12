using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Flyweight
{
    interface IFlyableCharacteristics
    {
        double[] AfterOneTimeStep(double[] position, double[] velocity, double timeStep);        

    }
}
