using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface ITarget
    {
        double request(int argumentA, int baseB);
    }
}
