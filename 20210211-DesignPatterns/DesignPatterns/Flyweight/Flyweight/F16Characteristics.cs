using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Flyweight
{
    class F16Characteristics : IFlyableCharacteristics
    {
        private int Mass = 12000;
        private double DragCoefficient = 0.02;
        private double LiftCoefficient = 0.8;
        private double PitchCoefficient = 0.2;

        public F16Characteristics(int mass, double dragCoefficient, double liftCoefficient, double pitchCoefficient)
        {
            Mass = mass;
            DragCoefficient = dragCoefficient;
            LiftCoefficient = liftCoefficient;
            PitchCoefficient = pitchCoefficient;
        }

        public double[] AfterOneTimeStep(double[] position, double[] velocity, double timeStep)
        {
            double[] result = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //computation here
            return result;
        }
    }
}
