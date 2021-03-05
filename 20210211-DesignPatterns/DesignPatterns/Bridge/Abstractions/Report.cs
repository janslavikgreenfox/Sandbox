using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Implementations;

namespace Bridge.Abstractions
{
    abstract class Report
    {
        public IReportable Implementation { get; protected set; }
        protected Report(IReportable implementation)
        {
            Implementation = implementation;
        }
        public virtual string Assembly() 
        {
            return this.Implementation.Create();
        }
    }
}
