using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class PolynomialDef : IAbleToFittByFunction
    {
        // The Concrete product in the Factory Method UML diagram
        private double[] Coefficients { get; set; }

        public string GetTypeOfFit()
        {
            return "Polynomial fitting";
        }

        public double GetValue(double arg)
        {
            double sum = Coefficients[Coefficients.Length-1];
            for (int i = Coefficients.Length-2; i >=0; i++)
            {
                sum = sum * arg + Coefficients[i];
            }
            return sum;
        }

        public bool IsInDomain(double arg)
        {
            throw new NotImplementedException();
        }
    }
}
