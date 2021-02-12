using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.ProductA;

namespace AbstractFactory.ProductB
{
    class ConcreteProductB2 : Interpolation
    {
        public ConcreteProductB2()
        {
            EvaluationFcn = AverageValue ;
        }

        private double AverageValue(ITable table, double arg)
        {
            var index = 0;
            while (index < table.Count() && arg < table.X(index))
            {
                index++;
            }
            if (index == table.Count())
            {
                return table.Y(index - 1);
            }
            else 
            {
                if (index == 0)
                {
                    return table.Y(index);
                }
                else
                {
                    return (table.Y(index - 1) + table.Y(index)) / 2;
                }
            }
        }
    }
}
