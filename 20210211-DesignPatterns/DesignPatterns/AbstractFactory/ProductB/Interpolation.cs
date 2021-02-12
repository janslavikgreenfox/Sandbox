using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.ProductA;

namespace AbstractFactory.ProductB
{
    delegate double InterpolationFunction(ITable table, double arg);
    class Interpolation
    {
        protected InterpolationFunction EvaluationFcn;

        public Interpolation()
        {
            EvaluationFcn = PicewiseLinear;
        }

        public double GetValue(ITable table, double arg)
        {
            return EvaluationFcn(table, arg);
        }

        private double PicewiseLinear(ITable table, double arg)
        {
            var index = 0;
            while (index<table.Count() && arg < table.X(index))
            {
                index++;
            }
            if (index == 0)
            {
                return table.Y(0);
            }
            if (index == table.Count())
            {
                return table.Y(index - 1);
            }
            else
            {
                var xAfter = table.X(index);
                var xBefore = table.X(index - 1);
                var yAfter = table.Y(index);
                var yBefore = table.Y(index - 1);
                return
                    (yAfter - yBefore) / (xAfter - xBefore) * (arg - xBefore);
            }
        } 
     
    }
}
