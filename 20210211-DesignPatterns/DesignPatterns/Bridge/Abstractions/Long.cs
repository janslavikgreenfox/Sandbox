using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Implementations;

namespace Bridge.Abstractions
{
    class Long : Report
    {
        public Long(IReportable implementation) : base(implementation)
        {}
    }
}
