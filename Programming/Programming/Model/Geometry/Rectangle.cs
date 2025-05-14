using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Static;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Класс прямоугольника.
    /// </summary>
    internal class Rectangle
    {
        /// <summary>
        /// Автосвойство количества сгенерированных прямоугольников.
        /// </summary>
        private static int AllRectanglesCount { get; set; } = 0;

        /// <summary>
        /// Ширина.
        /// </summary>
        private double _width = 0;

        /// <summary>
        /// Высота.
        /// </summary>
        private double _height = 0;

        /// <summary>
        /// Свойство ширины прямоугольника.
        /// Ширина - положительное число.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Width");
                _width = value;
            }
        }

        /// <summary>
        /// Свойство высоты прямоугольника.
        /// Высота - положительное число.
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Height");
                _height = value;
            }
        }

        /// <summary>
        /// Автосвойства центра координат прямоугольника.
        /// </summary>
        public Point2D Center { get; } = new Point2D();

        /// <summary>
        /// Автосвойство цвета прямоугольника.
        /// </summary>
        public string Color { get; set; } = "Black";

        /// <summary>
        /// Автосвойства уникального идентификатора прямоугольника.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Расширенный конструктор прямоугольника.
        /// </summary>
        /// <param name="width"> Ширина. </param>
        /// <param name="height"> Высота. </param>
        /// <param name="color"> Цвет. </param>
        /// <param name="center"> Координаты центра. </param>
        public Rectangle(double width, double height, string color, Point2D center)
        {
            Width = width;
            Height = height;
            Color = color;
            Center = center;
            Id = ++AllRectanglesCount;
        }

        /// <summary>
        /// Стандартный конструктор класса.
        /// </summary>
        public Rectangle() { }
    }
}
