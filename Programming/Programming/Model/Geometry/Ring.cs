using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Static;

namespace Programming.Model.Geometry
{
    internal class Ring
    {
        private double _outsideRadius;
        private double _insideRadius;

        public double OutsideRadius
        {
            get
            {
                return _outsideRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, "OutsideRadius");
                _outsideRadius = value;
            }
        }

        public double InsideRadius
        {
            get
            {
                return _insideRadius;
            }
            private set
            {
                Validator.AssertValueInRange(value, 0, _outsideRadius, "InsideRadius");
                _insideRadius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(_outsideRadius, 2) - Math.Pow(_insideRadius, 2));
            }
        }

        public Point2D Center { get; private set; }

        public Ring(double outsideRadius, double insideRadius, Point2D center)
        {
            OutsideRadius = outsideRadius;
            InsideRadius = insideRadius;
            Center = center;
        }
    }
}
