using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteListApp.Model.Classes
{
    /// <summary>
    /// Класс, задающий набор констант.
    /// </summary>
    static class Constants
    {
        /// <summary>
        /// Статическое автосвойство, которое определяет максимальную длину
        /// заголовка заметки.
        /// </summary>
        public static int MaxTitleCharactersLength { get; } = 100;

        /// <summary>
        /// Статическое автосвойство, которое определяет максимальную длину
        /// заголовка заметки.
        /// </summary>
        public static int MinTitleCharactersLength { get; } = 0;

        /// <summary>
        /// Статическое автосвойство, которое определяет цвет заднего фона
        /// поля, в котором введено ошибочное значение.
        /// </summary>
        public static System.Drawing.Color WrongColor { get; } = System.Drawing.Color.LightPink;

        /// <summary>
        /// Статическое автосвойство, которое определяет цвет заднего фона
        /// поля, в котором введено ошибочное значение.
        /// </summary>
        public static System.Drawing.Color DefaultTextBoxColor { get; } = System.Drawing.Color.White;
    }
}
