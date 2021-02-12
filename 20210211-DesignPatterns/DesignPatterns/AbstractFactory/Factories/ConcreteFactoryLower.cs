﻿using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.ProductA;
using AbstractFactory.ProductB;

namespace AbstractFactory.Factories
{
    class ConcreteFactoryLower : IAbstractFactory
    {
        public Interpolation CreateInterpolation()
        {
            return new ConcreteProductB3();
        }

        public ITable CreateTable(double[] x, double[] y)
        {
            return new ConcreteProductA1(x,y);
        }

        public ITable CreateTable()
        {
            var emptyVector = new double[] { };
            return new ConcreteProductA1(emptyVector, emptyVector);
        }
    }
}
