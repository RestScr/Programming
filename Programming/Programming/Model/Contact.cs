using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private string _phoneNumber = "";
        private string _name = "";
        private string _surname = "";

        // <summary>
        // Метод, проверяющий, состоит ли строка из латинских символов
        // если нет, то происходит возврат исключения ArgumentException
        // </summary>
        // <param name="value"> Строковый аргумент </param>
        // <param name="valueName"> Название свойства для ссылки на него в тексте исключения </param>
        private void AssertOnStringArgumentForEnglishLetters(string value, string valueName)
        {
            foreach (char character in value)
            {
                if (char.ToLower(character) < 'a' || char.ToLower(character) > 'z')
                {
                    throw new ArgumentException(valueName + " value can only be written in english");
                }
            }
        }

        public string Name 
        { 
            get 
            {
                return _name;
            }
            set 
            {
                AssertStringArgumentForEnglishLetters(value, "Name");
                _name = value;
            }
        }
        public string Surname 
        {
            get 
            {
                return _surname;
            } 
            set
            {
                AssertStringArgumentForEnglishLetters(value, "Surname");
                _surname = value;
            }
        }
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

        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public Contact() { }
    }
}
