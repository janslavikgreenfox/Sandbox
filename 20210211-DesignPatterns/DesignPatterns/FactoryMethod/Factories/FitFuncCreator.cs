using System;
using System.Collections.Generic;
using System.Text;
using static FactoryMethod.Program;

namespace FactoryMethod
{
    public abstract class FitFuncCreator
    {
        public abstract IAbleToFittByFunction Create(FitFunctionType fitFunctionType);
    
    }
}
