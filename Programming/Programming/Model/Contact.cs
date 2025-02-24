using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private string _phoneNumber = "88005553535";

        public string Name { get; set; } = "Andrey";
        public string Surname { get; set; } = "Bobov";
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
