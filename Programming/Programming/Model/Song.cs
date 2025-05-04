using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Static;

namespace Programming.Model
{
    internal class Song
    {
        private int _releaseYear = 1990;
        private int _durationInSeconds = 0;

        public string Author { get; set; } = "";
        public string Name { get; set; } = "";

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

        public Song(string name, int releaseYear, int durationInSeconds)
        {
            Name = name;
            ReleaseYear = releaseYear;
            DurationInSeconds = durationInSeconds;
        }

        public Song() { }
    }
}
