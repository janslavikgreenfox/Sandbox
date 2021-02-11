using System;
using System.Collections.Generic;
using System.Text;
using static FactoryMethod.Program;

namespace FactoryMethod
{
    public abstract class FitFuncCreator
    {
        // Creator role in the Factory Mehtod UML diagram
        public abstract IAbleToFittByFunction Create(FitFunctionType fitFunctionType);
    
    }
}
