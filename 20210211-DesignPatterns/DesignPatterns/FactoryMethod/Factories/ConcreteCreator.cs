using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactory.Program;

namespace AbstractFactory
{
    class ConcreteCreator : FitFuncCreator
    {
        public IAbleToFittByFunction Create(FitFunctionType fitFunctionType)
        {
            switch (fitFunctionType)
            {
                case FitFunctionType.Polynomial:
                    return new PolynomialDef();
                case FitFunctionType.Table:
                    return new TableDef();
                case FitFunctionType.Spline:
                    return null;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
