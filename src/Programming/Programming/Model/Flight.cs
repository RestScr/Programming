using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Static;

namespace Programming.Model
{
    /// <summary>
    /// Класс рейса самолета.
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Длительность полета в минутах.
        /// </summary>
        private int _flightTimeInMinutes = 0;

        /// <summary>
        /// Место вылета.
        /// </summary>
        public string DeparturePoint { get; set; } = "";

        /// <summary>
        /// Место назначения.
        /// </summary>
        public string DestinationPoint { get; set; } = "";

        /// <summary>
        /// Свойство, осуществляющее правильное задание времени полета в минутах.
        /// Время - положительное число.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTimeInMinutes = value;
            }
        }

        /// <summary>
        /// Расширенный конструктор авиарейса.
        /// </summary>
        /// <param name="flightTimeInMinutes"> Время полета. </param>
        /// <param name="departurePoint"> Место отправления. </param>
        /// <param name="destinationPoint"> Место назначения. </param>
        public Flight(int flightTimeInMinutes, string departurePoint, string destinationPoint)
        {
            FlightTimeInMinutes = flightTimeInMinutes;
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
        }

        /// <summary>
        /// Стандартный конструктор класса.
        /// </summary>
        public Flight() { }
    }
}
