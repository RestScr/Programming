using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Класс точки на плоскости.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Автосвойство абсциссы.
        /// </summary>
        public double X { get; set; } = 0;

        /// <summary>
        /// Автосвойство ординаты.
        /// </summary>
        public double Y { get; set; } = 0;

        /// <summary>
        /// Расширенный конструктор точки
        /// </summary>
        /// <param name="x"> Абсцисса точки. </param>
        /// <param name="y"> Ордината точки. </param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Стандартный конструктор класса.
        /// </summary>
        public Point2D()
        {

        }
    }
}
