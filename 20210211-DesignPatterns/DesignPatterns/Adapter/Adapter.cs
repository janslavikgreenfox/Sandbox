using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public double request(int argumentA, int baseB)
        {
            return this.adaptee.specificRequest(baseB,argumentA);
        }
    }
}
