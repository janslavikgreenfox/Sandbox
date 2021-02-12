using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.ProductA;

namespace AbstractFactory.ProductB
{
    class ConcreteProductB3 : Interpolation
    {
        public ConcreteProductB3()
        {
            EvaluationFcn = NearestLower;
        }

        private double NearestLower(ITable table, double arg)
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
                return table.Y(index);
            }
        }
    }
}
