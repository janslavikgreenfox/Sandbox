using System;
using System.Collections.Generic;
using System.Text;

namespace Snake.src
{
    class Position
    { 
        public int X { private set; get; }
        public int Y { private set; get; }

        Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
