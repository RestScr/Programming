using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        private int _durationInMinutes = 0;
        private int _releaseYear = 1990;
        private double _rating = 0.0;

        public string Name { get; set; } = "";

        public int DurationInMinutes
        {
            get 
            {
                return _durationInMinutes;
            }
            set
            {
                Model.Validator.AssertOnPositiveValue(value, "DurationInMinutes");

                _durationInMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if (value < 1990 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Year of release only can be greater than 1990 and less than current year");
                }

                _releaseYear = value;
            }
        }

        public string Genre { get; set; } = "";

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Rating can be only between 0 and 10");
                }

                _rating = value;
            }
        }

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
