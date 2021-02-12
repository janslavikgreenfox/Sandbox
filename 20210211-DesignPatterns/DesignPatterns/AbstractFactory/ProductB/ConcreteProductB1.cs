using AbstractFactory.ProductA;

namespace AbstractFactory.ProductB
{
    class ConcreteProductB1 : Interpolation
    {
        public ConcreteProductB1()
        {
            EvaluationFcn = NearestUpper;
        }

        private double NearestUpper(ITable table, double arg)
        {
            var index = table.Count();
            while(index >= 0 && arg < table.X(index))
            {
                index--;
            }
            if (index == table.Count())
            {
                return table.Y(index-1);
            }
            else
            {
                return table.Y(index);
            }
        }
    }
}
