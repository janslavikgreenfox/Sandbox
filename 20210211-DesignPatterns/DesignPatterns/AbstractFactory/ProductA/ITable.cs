using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductA
{
    public interface ITable
    {
        // Product A interface 
        int Count();
        double X(int index);
        double Y(int index);
    }
}
