using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.ProductA
{
    class ConcreteProductA2 : ITable
    {
        protected List<Tuple<double,double>> Representation { private set; get; }
        public ConcreteProductA2(double[] x, double [] y)
        {
            Representation = new List<Tuple<double, double>>();
            for (int i = 0; i < x.Length; i++)
            {
                var tuple = new Tuple<double, double> ( x[i], y[i] );
                Representation.Add(tuple);
            }
        }

        public int Count()
        {
            return Representation.Count();
        }

        public double X(int index)
        {
            return Representation[index].Item1;
        }

        public double Y(int index)
        {
            return Representation[index].Item2;
        }
    }
}
