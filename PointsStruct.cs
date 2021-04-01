using System;
using System.Collections.Generic;
using System.Text;

namespace VectorDistance
{
    public struct Points
    {
        public int x, y;

        public Points(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Points(Random point)
        {
            this.x = point.Next(1, 101);
            this.y = point.Next(1, 101);
        }
    }
}
