using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double deltaCenterX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double deltaCenterY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            double deltaWidth = Math.Abs(rectangle1.Width + rectangle2.Width);
            double deltaHeight = Math.Abs(rectangle1.Height + rectangle2.Height);

            return deltaCenterX < deltaWidth / 2 && deltaCenterY < deltaHeight / 2;
        }

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
