using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Prototypes
{
    interface IPrototype
    {
        IPrototype Clone();
        void ChangeXCoordinates(double[] newValue);
    }
}
