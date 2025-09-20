using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс покупателя.
    /// </summary>
    internal class Customer
    {
        private static int _createdCustomers = 0;

        private int _id;
        private string _fullname;
        private string _address;

        /// <summary>
        /// Свойство идентификатора объекта.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            init
            {
                if (value < 1)
                {
                    throw new ArgumentException("Class object's identificator must be positive");
                }

                _id = value;
            }
        }

        /// <summary>
        /// Свойство ФИО покупателя.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Свойство адреса покупателя.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, "Address");

                _address = value;
            }
        }

        /// <summary>
        /// Конструктор класса покупателя.
        /// </summary>
        /// <param name="fullname"> ФИО покупателя. </param>
        /// <param name="address"> Адрес проживания (доставки) покупателя. </param>
        public Customer(string fullname, string address)
        {
            Id = ++_createdCustomers;
            Fullname = fullname;
            Address = address;
        }
    }
}
