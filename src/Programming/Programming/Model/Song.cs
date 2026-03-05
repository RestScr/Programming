using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Static;

namespace Programming.Model
{
    /// <summary>
    /// Класс песни.
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _releaseYear = 1990;

        /// <summary>
        /// Длительность в секундах.
        /// </summary>
        private int _durationInSeconds = 0;

        /// <summary>
        /// Автосвойство имени автора.
        /// </summary>
        public string Author { get; set; } = "";

        /// <summary>
        /// Автосвойство названия песни
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Свойство, осуществляющее правильное задание года выпуска.
        /// Год выпуска - целое число от 1990 до текущего года.
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1990, DateTime.Now.Year);
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Свойство, осуществляющее правильное задание длительности песни.
        /// Длительность - положительное число.
        /// </summary>
        public int DurationInSeconds
        {
            get
            {
                return _durationInSeconds;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _durationInSeconds = value;
            }
        }

        /// <summary>
        /// Расширенный конструктор класса.
        /// </summary>
        /// <param name="name"> Название песни </param>
        /// <param name="author"> Имя автора песни. </param>
        /// <param name="releaseYear"> Год выпуска. </param>
        /// <param name="durationInSeconds"> Длительность песни. </param>
        public Song(string name, string author, int releaseYear, int durationInSeconds)
        {
            Name = name;
            Author = author;
            ReleaseYear = releaseYear;
            DurationInSeconds = durationInSeconds;
        }

        /// <summary>
        /// Стандартный конструктор класса.
        /// </summary>
        public Song() { }
    }
}
