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

        public string Name 
        { 
            get 
            {
                return _name;
            }
            set 
            {
                Model.Validator.AssertOnStringArgumentForEnglishLetters(value, "Name");
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
                Model.Validator.AssertOnStringArgumentForEnglishLetters(value, "Surname");
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
