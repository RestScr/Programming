using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Static
{
    internal static class AppColors
    {
        public static System.Drawing.Color WrongValueColor { get; } = System.Drawing.Color.LightPink;
        public static System.Drawing.Color BasicTextBoxColor { get; } = System.Drawing.Color.White;
        public static System.Drawing.Color DrawnRectangleColor { get; } = System.Drawing.Color.FromArgb(127, 127, 255, 127);
        public static System.Drawing.Color CollisionColor { get; } = System.Drawing.Color.FromArgb(127, 255, 127, 127);
    }
}
