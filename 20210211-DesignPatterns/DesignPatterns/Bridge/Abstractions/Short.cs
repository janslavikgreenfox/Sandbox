using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Implementations;

namespace Bridge.Abstractions
{
    class Short : Report
    {
        public Short(IReportable implementation):base(implementation)
        {}
    }
}
