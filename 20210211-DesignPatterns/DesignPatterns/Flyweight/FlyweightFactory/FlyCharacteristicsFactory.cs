using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flyweight.Flyweight;

namespace Flyweight.FlyweightFactory
{
    class FlyCharacteristicsFactory
    {

        private List<BulletCharacteristics> AllBulletCharacteristic;
        public FlyCharacteristicsFactory()
        {
            AllBulletCharacteristic = new List<BulletCharacteristics>();
        }

        public BulletCharacteristics CreateBulletCharacteristics(int mass)
        {
            if (!AllBulletCharacteristic.Any(x=>x.Mass==mass))
            {
                AllBulletCharacteristic.Add(new BulletCharacteristics(mass));
            }
            return AllBulletCharacteristic.Where(x => x.Mass == mass).First();
        }

        public F16Characteristics CreateF16Characteristics(
            int mass, 
            double dragCoefficient, 
            double liftCoefficient, 
            double pitchCoefficient
            )
        {
            return new F16Characteristics(
                mass, dragCoefficient, liftCoefficient, pitchCoefficient);
        }

    }
}
