using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    public class Point2D
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point2D() { }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
