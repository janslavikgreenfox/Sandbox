using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.ProductA;
using AbstractFactory.ProductB;

namespace AbstractFactory.Factories
{
    interface IAbstractFactory
    {
        ITable CreateTable();
        ITable CreateTable(double[] x, double[] y);
        Interpolation CreateInterpolation();
    }
}
