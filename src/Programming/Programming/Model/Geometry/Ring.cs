using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Static;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Класс кольца.
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outsideRadius;

        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _insideRadius;

        /// <summary>
        /// Свойство, задающее внешний радиус кольца.
        /// Внешний радиус - положительное число.
        /// </summary>
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

        /// <summary>
        /// Свойство, задающее внутренний радиус кольца.
        /// Внутренний радиус - число от 0 до внешнего радиуса.
        /// </summary>
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

        /// <summary>
        /// Вычисляемое свойство площади кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(_outsideRadius, 2) - Math.Pow(_insideRadius, 2));
            }
        }

        /// <summary>
        /// Автосвойство координат центра кольца.
        /// </summary>
        public Point2D Center { get; private set; }

        /// <summary>
        /// Расширенный конструктор класса.
        /// </summary>
        /// <param name="outsideRadius"> Внешний радиус. </param>
        /// <param name="insideRadius"> Внутренний радиус. </param>
        /// <param name="center"> Координаты центра кольуа. </param>
        public Ring(double outsideRadius, double insideRadius, Point2D center)
        {
            OutsideRadius = outsideRadius;
            InsideRadius = insideRadius;
            Center = center;
        }
    }
}
