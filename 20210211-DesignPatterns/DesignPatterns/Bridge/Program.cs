using System;
using System.Collections.Generic;
using Bridge.Abstractions;
using Bridge.Implementations;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var reports = new List<Report>()
            {
                new Short(new OnWorkstation()),
                new Short(new ParallelOnSMP()),
                new Short(new MassiveParallelOnClusters()),

                new Long(new OnWorkstation()),
                new Long(new ParallelOnSMP()),
                new Long(new MassiveParallelOnClusters())
            };

            foreach (var report in reports)
            {
                report.Assembly();
            }
        }
    }
}
