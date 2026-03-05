using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Static;

namespace Programming.Model
{
    /// <summary>
    /// Класс контакта в телефонной книге.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Номер телефона. Записывается только арабскими цифрами.
        /// </summary>
        private string _phoneNumber = "";
        /// <summary>
        /// Имя абонента. Записывается только латинскими буквами.
        /// </summary>
        private string _name = "";
        /// <summary>
        /// Фамилия абонента. Записывается только латинскими буквами.
        /// </summary>
        private string _surname = "";

        /// <summary>
        /// Свойство, задающее имя абонента.
        /// </summary>
        public string Name 
        { 
            get 
            {
                return _name;
            }
            set 
            {
                Validator.AssertOnStringArgumentForEnglishLetters(value, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Свойство, задающее фамилию абонента.
        /// Фамилия состоит только из латинских букв.
        /// </summary>
        public string Surname 
        {
            get 
            {
                return _surname;
            } 
            set
            {
                Validator.AssertOnStringArgumentForEnglishLetters(value, "Surname");
                _surname = value;
            }
        }

        /// <summary>
        /// Свойство, задающее номер телефона абонента.
        /// Номер телефона записывается только арабскими цифрами.
        /// </summary>
        public string PhoneNumber
        {
            get 
            {
                return _phoneNumber;
            }
            set
            {
                foreach (char symbol in value)
                {
                    if (!char.IsDigit(symbol))
                    {
                        throw new ArgumentException("Telephone Number can only contain digits");
                    }

                    _phoneNumber = value;
                }
            }
        }

        /// <summary>
        /// Расширенный конструктор контакта.
        /// </summary>
        /// <param name="name"> Имя абонента. </param>
        /// <param name="surname"> Фамилия абонента. </param>
        /// <param name="phoneNumber"> Номер абонента. </param>
        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Стандартный конструктор класса.
        /// </summary>
        public Contact() { }
    }
}
