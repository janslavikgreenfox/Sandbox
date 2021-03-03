using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adaptee
    {

        public double specificRequest(int baseB, int argumentA)
        {
            return logarithm(baseB, argumentA);
        }

        private double logarithm(int baseB, int argumentA)
        {
            return Math.Log2(argumentA) / Math.Log2(baseB); 
        }

    }
}
