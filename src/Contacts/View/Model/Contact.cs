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
        /// Функция изменения свойств с уведомлением.
        /// </summary>
        /// <param name="field"> Ссылка на поле. </param>
        /// <param name="value"> Значение для записи в поле. </param>
        /// <returns> 
        /// true, если значение было успешно записано в поле,
        /// false - если в поле итак записано одно и то же значение.
        /// </returns>
        public bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }
            else
            {
                field = value;
                OnPropertyChanged(PropertyName);
                return true;
            }
        }

        private string _name = "";

        public string Name
        {
            get => _name;
            set
            {
                Set(ref _name, value);
            }
        }

        private string _phoneNumber = "";

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                Set(ref _phoneNumber, value);
            }
        }

        private string _email;

        public string Email
        {
            get => _email;
            set
            {
                Set(ref _email, value);
            }
        }

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Contact()
        {
            Name = "";
            PhoneNumber = "";
            Email = "";
        }
    }
}
