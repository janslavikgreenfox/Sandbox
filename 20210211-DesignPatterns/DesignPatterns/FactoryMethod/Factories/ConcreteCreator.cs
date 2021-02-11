using System;
using System.Collections.Generic;
using System.Text;
using static FactoryMethod.Program;

namespace FactoryMethod
{
    public class ConcreteCreator : FitFuncCreator
    {
        // Concrete creator in the Factory Method UML diagram
        public override IAbleToFittByFunction Create(FitFunctionType fitFunctionType)
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
