using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Factories;
using AbstractFactory.ProductA;
using AbstractFactory.ProductB;

namespace AbstractFactory
{
    class FunctionDefinedByTable
    {
        // Client
        private readonly ITable table;
        private readonly Interpolation interpolation;
        public FunctionDefinedByTable(IAbstractFactory factory)
        {
            table = factory.CreateTable();
            interpolation = factory.CreateInterpolation();
        }

        public double GetValue(double arg)
        {
            return interpolation.GetValue(table, arg);
        }
    }
}
