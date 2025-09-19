using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Static;

namespace Programming.Model
{
    /// <summary>
    /// Класс фильма
    /// </summary>
    internal class Film
    {
        /// <summary>
        /// Длительность в минутах.
        /// </summary>
        private int _durationInMinutes = 0;
        
        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _releaseYear = 1990;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating = 0.0;

        /// <summary>
        /// Свойство, задающее название фильма.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Свойство, осуществляющее правильное задание длительности фильма.
        /// Длительность - положительное число.
        /// </summary>
        public int DurationInMinutes
        {
            get 
            {
                return _durationInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// Свойство, осуществляющее корректное задание года выпуска.
        /// Год выпуска задается в пределах от 1990 до текущего года.
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
        /// Свойство жанра.
        /// </summary>
        public string Genre { get; set; } = "";

        /// <summary>
        /// Свойство, осуществляющее правильное задание рейтинга.
        /// Рейтинг - число от 0 до 10.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0.0, 10.0);
                _rating = value;
            }
        }

        /// <summary>
        /// Расширенный конструктор фильма.
        /// </summary>
        /// <param name="name"> Название фильма. </param>
        /// <param name="durationInMinutes"> Длительность в минутах. </param>
        /// <param name="releaseYear"> Год выпуска. </param>
        /// <param name="genre"> Жанр фильма. </param>
        /// <param name="rating"> Рейтинг фильма. </param>
        public Film(string name, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
    }
}
