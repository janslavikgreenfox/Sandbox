using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementations
{
    class MassiveParallelOnClusters : IReportable
    {
        public string Create()
        {
            Console.WriteLine("I am on a cluster and creating the report");
            return "Za'o prami loka";
        }
    }
}
