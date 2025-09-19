using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Static
{
    /// <summary>
    /// Статический класс, хранящий необходимые цветовые константы.
    /// </summary>
    internal static class AppColors
    {
        /// <summary>
        /// Цвет, отвечающий за цвет фона текстбоксов в случае неверно заданного значения.
        /// </summary>
        public static System.Drawing.Color WrongValueColor { get; } = System.Drawing.Color.LightPink;

        /// <summary>
        /// Цвет, отвечающий за стандартный цвет фона текстбоксов.
        /// </summary>
        public static System.Drawing.Color BasicTextBoxColor { get; } = System.Drawing.Color.White;

        /// <summary>
        /// Увет, отвечающий за цвет нарисованного прямоугольника.
        /// </summary>
        public static System.Drawing.Color DrawnRectangleColor { get; } = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет, отвечающий за перекрашивание прямоугольников в случае коллизии.
        /// </summary>
        public static System.Drawing.Color CollisionColor { get; } = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет осени.
        /// </summary>
        public static System.Drawing.Color AutumnColor { get; } = System.Drawing.Color.DarkOrange;

        /// <summary>
        /// Цвет зимы.
        /// </summary>
        public static System.Drawing.Color WinterColor { get; } = System.Drawing.Color.DarkGray;

        /// <summary>
        /// Цвет весны.
        /// </summary>
        public static System.Drawing.Color SpringColor { get; } = System.Drawing.Color.LightGreen;

        /// <summary>
        /// Цвет лета.
        /// </summary>
        public static System.Drawing.Color SummerColor { get; } = System.Drawing.Color.SkyBlue;

    }
}
