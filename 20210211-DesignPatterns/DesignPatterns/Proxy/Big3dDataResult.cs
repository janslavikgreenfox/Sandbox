using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Big3dDataResult : I3dData
    {
        private double []  Representation { get; set; }
        public Big3dDataResult(string filename)
        {
            this.Representation = LoadData(filename);
        }
        public int GetCellsCount()
        {
            Console.WriteLine("GetCellsCount in the Big3dDataResult");
            return Representation.Length;
        }
        private double[] LoadData(string filename)
        {
            // the 3d data load magic here  
            return new double[0];
        }
    }
}
