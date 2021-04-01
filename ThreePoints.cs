using System;
using System.Collections.Generic;
using System.Text;

namespace VectorDistance
{
    public struct ThreePoints
    {
        public int x, y, z;

        public ThreePoints(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public ThreePoints(Random point)
        {
            this.x = point.Next(1, 1001);
            this.y = point.Next(1, 1001);
            this.z = point.Next(1, 1001);
        }
    }
}
