using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    static class RectangleFactory
    {
        static private Random _random = new Random();
        static private double _canvasPadding = 15;

        private const double _maxRandomWidth = 200;
        private const double _maxRandomHeight = 200;

        /// <summary>
        /// Метод, генерирующий случайный прямоугольник
        /// </summary>
        /// <returns> Сгенерированный прямоугольник </returns>
        static public Geometry.Rectangle Randomize(Panel canvas, string color = "red")
        {
            double width = Math.Max(_random.NextDouble(), 0.5) * _maxRandomWidth;
            double height = Math.Max(_random.NextDouble(), 0.35) * _maxRandomHeight;
            double x = Math.Min(Math.Max(_random.NextDouble() * canvas.Width, width / 2 + _canvasPadding), canvas.Width - width / 2 - _canvasPadding);
            double y = Math.Min(Math.Max(_random.NextDouble() * canvas.Height, height / 2 + _canvasPadding), canvas.Height - height / 2 - _canvasPadding);
            return new Model.Geometry.Rectangle(
                        width,
                        height,
                        color,
                        new Point2D(x, y)
                       );
        }

        static public Geometry.Rectangle Randomize(string color = "red")
        {
            double width = Math.Max(_random.NextDouble(), 0.5) * _maxRandomWidth;
            double height = Math.Max(_random.NextDouble(), 0.35) * _maxRandomHeight;
            double x = Math.Min(Math.Max(_random.NextDouble() * width, width / 2 + _canvasPadding), width / 2 - _canvasPadding);
            double y = Math.Min(Math.Max(_random.NextDouble() * height, height / 2 + _canvasPadding), height - height / 2 - _canvasPadding);
            return new Model.Geometry.Rectangle(
                        width,
                        height,
                        color,
                        new Point2D(x, y)
                       );
        }
    }
}
