using System;
using Flyweight.FlyweightFactory;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var flyCharFactory = new FlyCharacteristicsFactory();

            // Flyweight sharing
            var b1 = flyCharFactory.CreateBulletCharacteristics(1);
            var b2 = flyCharFactory.CreateBulletCharacteristics(1);
            var b3 = flyCharFactory.CreateBulletCharacteristics(2);
            var b4 = flyCharFactory.CreateBulletCharacteristics(1);
            var b5 = flyCharFactory.CreateBulletCharacteristics(1);
            var b6 = flyCharFactory.CreateBulletCharacteristics(1);
            var b7 = flyCharFactory.CreateBulletCharacteristics(2);
            var b8 = flyCharFactory.CreateBulletCharacteristics(1);
            var b9 = flyCharFactory.CreateBulletCharacteristics(3);

            
            // No flyweight sharing
            var a1 = flyCharFactory.CreateF16Characteristics(
                11000, 0.01, 0.6, 0.12);

            var a2 = flyCharFactory.CreateF16Characteristics(
                11000, 0.01, 0.6, 0.12);
            
        }
    }
}
