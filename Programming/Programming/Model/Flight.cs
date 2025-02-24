using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Flight
    {
        private int _flightTimeInMinutes = 0;

        public string DeparturePoint { get; set; } = "";
        public string DestinationPoint { get; set; } = "";
        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeInMinutes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Flight time cannot be below zero.");
                }

                _flightTimeInMinutes = value;
            }
        }

        public Flight(int flightTimeInMinutes, string departurePoint, string destinationPoint)
        {
            FlightTimeInMinutes = flightTimeInMinutes;
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
        }

        public Flight() { }
    }
}
