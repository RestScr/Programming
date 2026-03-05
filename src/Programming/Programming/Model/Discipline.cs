using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс научной дисциплины.
    /// </summary>
    internal class Discipline
    {
        /// <summary>
        /// Имя предмета.
        /// </summary>
        public string SubjectName { get; set; } = "Maths";
        /// <summary>
        /// Имя преподавателя.
        /// </summary>
        public string LecturerName { get; set; } = "Mikhail";
        /// <summary>
        /// Фамилия преподавателя.
        /// </summary>
        public string LecturerSurname { get; set; } = "Kuznetsov";

        /// <summary>
        /// Оценка по предмету. Оценка в пределах от 0 до 5.
        /// </summary>
        private int _mark = 5;

        /// <summary>
        /// Свойство, задающее оценку по предмету.
        /// </summary>
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
        
        /// <summary>
        /// Расширенный конструктор дисциплины.
        /// </summary>
        /// <param name="subjectName"> Имя предмета. </param>
        /// <param name="lecturerName"> Имя преподавателя по предмету. </param>
        /// <param name="lecturerSurname"> Фамилия преподавателя по предмету. </param>
        /// <param name="mark"> Оценка по предмету. В пределах от 0 до 5. </param>
        public Discipline(string subjectName, string lecturerName, string lecturerSurname, int mark)
        {
            SubjectName = subjectName;
            LecturerName = lecturerName;
            LecturerSurname = lecturerSurname;
            Mark = mark;
        }

        /// <summary>
        /// Стандартный конструктор дисциплины
        /// </summary>
        public Discipline() { }
    }
}
