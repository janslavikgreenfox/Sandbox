using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public delegate double Scale(double x, double module);
    public class Axis
    {
        // Reciever
        const double GraduationLength = 1.0;
        private double LowerLimit { get; set; }
        private double UpperLimit { get; set; }
        private int TicksCount { get; set; }
        public Scale CurrentScale { get; set; }
        private double Module { get; set; }
        public Axis(double lowerLimit=0, double upperLimit=1, int ticksCount=10, double module=1)
        {
            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
            TicksCount = ticksCount;
            CurrentScale = LinearScale;
            Module = module;
        }

        private double LinearScale(double x, double module)
        {
            Console.WriteLine($"LinearScale = Module {module} * ( {x} )");
            return module * x;
        }

        public void ChangeScale(Scale scale)
        {
            this.CurrentScale = scale;
        }

        public void ScaleToLinear()
        {
            this.CurrentScale = LinearScale;
        }



    }
}
