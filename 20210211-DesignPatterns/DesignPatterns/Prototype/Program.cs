using System;
using System.Collections.Generic;
using Prototype.Prototypes;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var prototype = new CFDMesh(
                new double[] { 0.0, 0.5, 0.8},
                new double[] { 0.0, 0.0, 1.0},
                new double[] { 0.0, -0.5, +0.25},
                new List<Tuple<int, int>>() 
                { Tuple.Create(0,1),
                    Tuple.Create(0,2),
                    Tuple.Create(1,2)}
                );

            var derived = prototype.Clone();
            derived.ChangeXCoordinates(new double[] { -1.0, -2.0, -3.0 });

        }
    }
}
