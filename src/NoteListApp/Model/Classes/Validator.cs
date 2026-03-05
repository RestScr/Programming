using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteListApp.Model.Classes
{
    /// <summary>
    /// Статический сервисный класс валидатора.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Метод, который определяет, меньше ли длина строки заданного
        /// количества символов.
        /// </summary>
        /// <param name="line"> Строка для проверки. </param>
        /// <param name="maxCharacters"> Максимальная возможная длина в символах. </param>
        /// <returns> Удовлетворяет ли строка условию </returns>
        static public bool AssertOnCharacterLength(string line, int maxCharacters, int minCharacters=0)
        {
            return (line.Length >= minCharacters) && (line.Length <= maxCharacters);
        }
    }
}
