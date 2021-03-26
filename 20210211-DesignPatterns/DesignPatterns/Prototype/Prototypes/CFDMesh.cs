using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Prototypes
{
    class CFDMesh : IPrototype
    {
        private double[] Xcoordinates { set; get; }
        private double[] Ycoordinates { set; get; }
        private double[] Zcoordinates { set; get; }
        private List<Tuple<int,int>> AdjacentVertexes { set; get; }
        public CFDMesh(
            double[] xcoordinates, double[] ycoordinates, double[] zcoordinates, List<Tuple<int,int>> adjacentVertexes)
        {
            Xcoordinates = xcoordinates;
            Ycoordinates = ycoordinates;
            Zcoordinates = zcoordinates;
            AdjacentVertexes = adjacentVertexes;
        }

        public CFDMesh(CFDMesh other)
        {
            Xcoordinates = other.Xcoordinates;
            Ycoordinates = other.Ycoordinates;
            Zcoordinates = other.Zcoordinates;
            AdjacentVertexes = other.AdjacentVertexes;
                    }

        public IPrototype Clone()
        {
            return new CFDMesh(this);
        }

        public void ChangeXCoordinates(double[] newValue)
        {
            Xcoordinates = newValue;
        }
    }
}
