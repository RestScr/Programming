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
                Model.Validator.AssertValueInRange(value, 0, 23);
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
                Model.Validator.AssertValueInRange(value, 0, 59);
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
                Model.Validator.AssertValueInRange(value, 0, 59);
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
