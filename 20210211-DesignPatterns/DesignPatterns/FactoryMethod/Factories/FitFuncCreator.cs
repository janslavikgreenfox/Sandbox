using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FitFuncCreator
    {
        public virtual IAbleToFittByFunction Create()
        {
            return null;
        }
    }
}
