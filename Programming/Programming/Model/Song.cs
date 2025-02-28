using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private int _releaseYear = 1999;
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
                if (value < 1990 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Release Year can only be between 1990 and current year");
                }
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
                Model.Validator.AssertOnPositiveValue(value, "DurationInSeconds");
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
