using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class AircraftContext
    {
        private double Mass { get; set; }
        private double StallSpeed { get; set; }
        private double DesignSpeed { get; set; }
        private double LiftCoefficient { get; set; }
        private double Area { get; set; }
        public IFlyStrategy FlyBehaviour { get; set; }

        public AircraftContext(
            IFlyStrategy iFlyStrategy,
            double mass = 1000,
            double stallSpeed = 45,
            double designSpeed = 210,
            double liftCoeff = 1.0,
            double area = 10.0
            )
        {
            this.FlyBehaviour = iFlyStrategy;
            this.Mass = mass;
            this.StallSpeed = stallSpeed;
            this.DesignSpeed = designSpeed;
            this.LiftCoefficient = liftCoeff;
            this.Area = area;
        }
        public double GetMaximalLoad()
        {
            return FlyBehaviour.MaximalLoad(Mass, StallSpeed, DesignSpeed, LiftCoefficient);
        }
    }
}
