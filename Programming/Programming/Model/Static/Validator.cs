using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Static
{
    public static class Validator
    {
        // <summary>
        // Валидатор положительного значения целочисленного свойства
        // </summary>
        // <param name="value"> Целочисленное значение свойства </param>
        // <param name="valueName"> Имя свойства для ссылки на него в тексте исключения </param>
        public static void AssertOnPositiveValue(int value, [CallerMemberName] string valueName = "")
        {
            if (value < 0)
            {
                throw new ArgumentException(valueName + " value cannot be below zero");
            }
        }

        // <summary>
        // Валидатор положительного значения вещественного свойства (перегруженный метод)
        // </summary>
        // <param name="value"> Значение вещественного свойства </param>
        // <param name="valueName"> Имя свойства для ссылки на него в тексте исключения </param>
        public static void AssertOnPositiveValue(double value, [CallerMemberName] string valueName = "")
        {
            if (value < 0)
            {
                throw new ArgumentException(valueName + " value cannot be below zero");
            }
        }

        // <summary>
        // Валидатор записи строкового значения свойства латинскими буквами
        // </summary>
        // <param name="value"> Строковое значение свойства </param>
        // <param name="valueName"> Название свойства для ссылки на него в тексте исключения </param>
        public static void AssertOnStringArgumentForEnglishLetters(string value, [CallerMemberName] string valueName = "")
        {
            foreach (char character in value)
            {
                if (char.ToLower(character) < 'a' || char.ToLower(character) > 'z')
                {
                    throw new ArgumentException(valueName + " value can only be written in english");
                }
            }
        }

        // <summary>
        // Метод валидации целочисленного свойства в определённом диапазоне
        // </summary>
        // <param name="value"> Само значение свойства </param>
        // <param name="min"> Минимальное допустимое значение свойства </param>
        // <param name="max"> Максимальное допустимое значение свойства </param>
        // <param name="valueName"> Имя свойства, откуда был вызван валидатор </param>
        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string valueName = "")
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(valueName + $" value can only be in between {min} and {max}");
            }
        }

        // <summary>
        // Метод валидации вещественного свойства в определённом диапазоне (перегруженный метод)
        // </summary>
        // <param name="value"> Само значение свойства </param>
        // <param name="min"> Минимальное допустимое значение свойства </param>
        // <param name="max"> Максимальное допустимое значение свойства </param>
        // <param name="valueName"> Имя свойства, откуда был вызван валидатор </param>
        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string valueName = "")
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(valueName + $" value can only be in between {min} and {max}");
            }
        }
    }
}
