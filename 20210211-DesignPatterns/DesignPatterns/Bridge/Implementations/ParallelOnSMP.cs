using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementations
{
    class ParallelOnSMP : IReportable
    {
        public string Create()
        {
            Console.WriteLine("I am on a SMP machine and creating the report");
            return "Loren ipsum SMP";
        }
    }
}
