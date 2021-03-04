using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Proxy : I3dData
    {
        private Big3dDataResult big3dDataResult = null;
        public string Filename { get; set; }
        public Proxy(string filename)
        {
            this.Filename = filename;
        }
        public int GetCellsCount()
        {
            if(big3dDataResult is null)
            {
                Console.WriteLine("Lazy initialization - a lot of source consuming");
                big3dDataResult = new Big3dDataResult(Filename);
            }
            Console.WriteLine("Returning the count of cells");
            return big3dDataResult.GetCellsCount();
        }
    }
}
