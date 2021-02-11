using System;
using System.Linq;

namespace AbstractFactory
{
    class TableDef : IAbleToFittByFunction
    {
        private double[] X { get; set; }
        private double[] Y { get; set; }

        public string GetTypeOfFit()
        {
            return "Lookup table fitting";
        }

        public double GetValue(double arg)
        {
            return X.OrderBy(x => Math.Abs(x - arg)).FirstOrDefault();
        }

        public bool IsInDomain(double arg)
        {
            return X.Min()<= arg && arg <= X.Max();
        }
    }
}
