using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс валидации данных.
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Метод валидации текстовых данных по длине.
        /// </summary>
        /// <param name="text"> Само содержание строки. </param>
        /// <param name="maxLength"> Максимальная длина строки. </param>
        /// <param name="propertyName"> Название свойства класса. </param>
        /// <exception cref="ArgumentException"> Возвращает ошибку в случае ошибки валидации. </exception>
        public static void AssertStringOnLength(string text, int maxLength, string propertyName)
        {
            if (text.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} must contain less than {maxLength}");
            }
        }

        /// <summary>
        /// Проверка введенной величины, находится ли она в определенном диапазоне.
        /// </summary>
        /// <param name="value"> Введенная величина. </param>
        /// <param name="minimal"> Нижнее значение. </param>
        /// <param name="maximal"> Верхнее значение. </param>
        /// <param name="propertyName"> Имя свойства для текста ошибки. </param>
        /// <exception cref="ArgumentException"> В случаее нарушения валидации выводится ошибка аргументов. </exception>
        public static void AssertValueInRange(double value, double minimal, double maximal, string propertyName)
        {
            if (value < minimal || value > maximal)
            {
                throw new ArgumentException($"{propertyName} must be a value between {minimal} and {maximal}");
            }
        }

        /// <summary>
        /// Проверить введённую величину на положительность.
        /// </summary>
        /// <param name="value"> Введенное значение. </param>
        /// <param name="propertyName"> Имя свойства для сообщения об исключении. </param>
        /// <exception cref="ArgumentException"> В случае ошибки валидации выводится ошибка аргументации. </exception>
        public static void AssertValueOnPositive(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} must be a positive number");
            }
        }

        /// <summary>
        /// Проверить, является ли даннаяs строка числом.
        /// </summary>
        /// <param name="value"> Значение для проверки. </param>
        /// <exception cref="ArgumentException"> В случае ошибки выводится ошибка аргументации. </exception>
        public static void AssertStringOnNumber(string value, string propertyName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < '0' || value[i] > '9')
                {
                    throw new ArgumentException(propertyName + " must be numerical");
                }
            }
        }

        /// <summary>
        /// Проверить, равна ли длина строки определенному количеству.
        /// </summary>
        /// <param name="value"> Введенное значение. </param>
        /// <param name="length"> Необходимая длина строки. </param>
        /// <param name="propertyName"> Название свойства. </param>
        /// <exception cref="ArgumentException"> В случае ошибки валидации возвращается ошибка аргументации. </exception>
        public static void AssertStringOnStrictLengthEquality(string value, int length, string propertyName)
        {
            if (value.Length != length)
            {
                throw new ArgumentException(propertyName + " length must be " + length);
            }
        }
    }
}
