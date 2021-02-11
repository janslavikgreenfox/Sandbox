using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IAbleToFittByFunction
    {
        public string GetTypeOfFit();
        public double GetValue(double arg);
        public bool IsInDomain(double arg);
    }
}
