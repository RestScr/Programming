using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Point2D
    {
        public double X { get; } = 0;
        public double Y { get; } = 0;

        public Point2D() { }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
