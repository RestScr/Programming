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
                Model.Validator.AssertOnPositiveValue(value);
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
                Model.Validator.AssertValueInRange(value, 1990, DateTime.Now.Year);
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
                Model.Validator.AssertValueInRange(value, 0.0, 10.0);
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
