using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Subject
{
    class OneVertex : ISubject
    {
        private int[] Representation { get; set; }
        public OneVertex(int[] representation)
        {
            Representation = representation;
        }

        public int[] GetRepresentation()
        {
            return Representation;
        }
    }
}
