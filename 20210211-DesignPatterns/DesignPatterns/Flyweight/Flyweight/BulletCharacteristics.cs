using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Flyweight
{
    class BulletCharacteristics : IFlyableCharacteristics
    {

        public int Mass { get; private set; }
        public BulletCharacteristics(int mass)
        {
            Mass = mass;
        }

       

        public double[] AfterOneTimeStep(double[] position, double[] velocity, double timeStep)
        {
            double[] result = { 0,0,0,0,0,0,0,0,0,0,0,0};
            //computation here
            return result;
        }
    }
}
