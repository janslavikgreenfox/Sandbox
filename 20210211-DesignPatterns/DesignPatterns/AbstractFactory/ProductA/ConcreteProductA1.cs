using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductA
{
    class ConcreteProductA1 : ITable
    {
        protected double[] xRepresentation { private set; get; }
        protected double[] yRepresentation { private set; get; }

        public ConcreteProductA1(double[] x, double[] y)
        {
            xRepresentation = x;
            yRepresentation = y;
        }
        public int Count()
        {
            return xRepresentation.Length;
        }

        public double X(int index)
        {
            return xRepresentation[index];
        }

        public double Y(int index)
        {
            return yRepresentation[index];
        }
    }
}
