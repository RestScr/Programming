using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс валидации данных
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Метод валидации текстовых данных по длине
        /// </summary>
        /// <param name="text"> Само содержание строки </param>
        /// <param name="maxLength"> Максимальная длина строки </param>
        /// <param name="propertyName"> Название свойства класса </param>
        /// <exception cref="ArgumentException"> Возвращает ошибку в случае ошибки валидации </exception>
        public static void AssertStringOnLength(string text, int maxLength, string propertyName)
        {
            if (text.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} must contain less than {maxLength}");
            }
        }

        public static void AssertValueInRange(double value, double minimal, double maximal, string propertyName)
        {
            if (value < minimal || value > maximal)
            {
                throw new ArgumentException($"{propertyName} must be a value between {minimal} and {maximal}");
            }
        }

        public static void AssertValueOnPositive(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} must be a positive number");
            }
        }
    }
}
