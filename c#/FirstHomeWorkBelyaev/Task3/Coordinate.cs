using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Coordinate
    {
        double x;
        double y;

        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getDistanceTo(Coordinate coordinate)
        {
            return Math.Sqrt(Math.Pow(coordinate.x - this.x, 2) + Math.Pow(coordinate.y - this.y, 2));
        }
    }
}
