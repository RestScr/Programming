using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        private static int _createdCustomers = 0;

        private int _id;
        private string _fullname;
        private string _address;

        /// <summary>
        /// Свойство идентификатора объекта
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
        /// Свойство ФИО покупателя
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (value.Length > 200)
                {
                    throw new ArgumentException("Customer's fullname can contain less than 200 symbols");
                }
                _fullname = value;
            }
        }

        /// <summary>
        /// Свойство адреса покупателя
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value.Length > 500)
                {
                    throw new ArgumentException("Customer's address field can contain less than 500 symbols");
                }

                _address = value;
            }
        }

        Customer(string fullname, string address)
        {
            Id = ++_createdCustomers;
            Fullname = fullname;
            Address = address;
        }
    }
}
