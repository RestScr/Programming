using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Сервисный класс, отвечающий за определение коллизий.
    /// </summary>
    internal static class CollisionManager
    {
        /// <summary>
        /// Метод определения наличии коллизии между двумя прямоугольниками.
        /// </summary>
        /// <param name="rectangle1"> Ссылка на первый прямоугольник. </param>
        /// <param name="rectangle2"> Ссылка на второй прямоугольник. </param>
        /// <returns> Есть ли коллизия. </returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double leftX = Math.Min(
                rectangle1.Center.X - rectangle1.Width / 2,
                rectangle2.Center.X - rectangle2.Width / 2
                );
            double rightX = Math.Max(
                rectangle1.Center.X + rectangle1.Width / 2,
                rectangle2.Center.X + rectangle2.Width / 2
                );

            double topY = Math.Max(
                rectangle1.Center.Y + rectangle1.Height / 2,
                rectangle2.Center.Y + rectangle2.Height / 2
                );
            double bottomY = Math.Min(
                rectangle1.Center.Y - rectangle1.Height / 2,
                rectangle2.Center.Y - rectangle2.Height / 2
                );

            double absDeltaX = rightX - leftX;
            double absDeltaY = topY - bottomY;

            double summaryWidth = rectangle1.Width + rectangle2.Width;
            double summaryHeight = rectangle1.Height + rectangle2.Height;

            return (absDeltaX < summaryWidth) && (absDeltaY < summaryHeight);
        }

        /// <summary>
        /// Метод определения коллизии между двумя кольцами.
        /// </summary>
        /// <param name="ring1"> Ссылка на первое кольцо. </param>
        /// <param name="ring2"> Ссылка на второе кольцо. </param>
        /// <returns> Есть ли коллизия. </returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double radiusSum = ring1.OutsideRadius + ring2.OutsideRadius;
            double deltaCenterX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double deltaCenterY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double centerDistance = Math.Sqrt(Math.Pow(deltaCenterX, 2) + Math.Pow(deltaCenterY, 2));

            return centerDistance < radiusSum;
        }
    }
}
