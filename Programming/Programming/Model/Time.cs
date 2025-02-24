using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int _hours = 14;
        private int _minutes = 18;
        private int _seconds = 10;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Hours value can be only between 0 and 23");
                }

                _hours = value;
            }
        }

        public int Minutes
        {
            get 
            { 
                return _minutes; 
            }
            set
            {
                if (value < 0 || value >= 60)
                {
                    throw new ArgumentException("Minutes value can only be between 0 and 59");
                }

                _minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value < 0 || value >= 60)
                {
                    throw new ArgumentException("Seconds value can only be between 0 and 59");
                }

                _seconds = value;
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time() { }
    }
}
