using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Static;

namespace Programming.Model
{
    /// <summary>
    /// Класс времени.
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours = 14;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes = 18;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds = 10;

        /// <summary>
        /// Свойство, задающее часы.
        /// Часы - число от 0 до 23.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 23);
                _hours = value;
            }
        }

        /// <summary>
        /// Свойство, осуществляющее корретное задание минут.
        /// Минуты - число от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get 
            { 
                return _minutes; 
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _minutes = value;
            }
        }

        /// <summary>
        /// Свойство, осуществляющее корректное задание секунд.
        /// Секунды - число от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _seconds = value;
            }
        }

        /// <summary>
        /// Расширенный конструктор класса.
        /// </summary>
        /// <param name="hours"> Часы. </param>
        /// <param name="minutes"> Минуты. </param>
        /// <param name="seconds"> Секунды. </param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Стандартный конструктор класса.
        /// </summary>
        public Time() { }
    }
}
