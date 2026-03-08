using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        /// <summary>
        /// Изменение данных.
        /// </summary>
        public virtual bool Set<T>(ref T Field, T Value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(Field, Value))
            {
                return false;
            }
            else
            {
                Field = Value;
                OnPropertyChanged(PropertyName);
                return true;
            }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                Set(ref _name, value);
            }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        private string _email;

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
