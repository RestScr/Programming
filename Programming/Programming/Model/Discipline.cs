using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Discipline
    {
        public string SubjectName { get; set; } = "Maths";
        public string LecturerName { get; set; } = "Mikhail";
        public string LecturerSurname { get; set; } = "Kuznetsov";

        private int _mark = 5;

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("Mark value can only be between 0 and 5");
                }

                _mark = value;
            }
        }
        
        public Discipline(string subjectName, string lecturerName, string lecturerSurname, int mark)
        {
            SubjectName = subjectName;
            LecturerName = lecturerName;
            LecturerSurname = lecturerSurname;
            Mark = mark;
        }

        public Discipline() { }
    }
}
