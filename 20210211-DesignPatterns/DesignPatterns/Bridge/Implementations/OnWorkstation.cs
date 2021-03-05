using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementations
{
    class OnWorkstation : IReportable
    {
        public string Create()
        {
            Console.WriteLine("I am on a workstation and creating the report");
            return "Loren ipsum";
        }
    }
}
