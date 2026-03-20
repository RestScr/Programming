using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Класс контакта.
    /// </summary>
    public class Contact : INotifyPropertyChanged
    {
        // --------------- События ---------------

        /// <summary>
        /// Событие изменения свойств контакта.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        // --------------------- Поля и свойства -------------

        /// <summary>
        /// Поле имени контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Свойство имени контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Set(ref _name, value);
            }
        }

        /// <summary>
        /// Поле номера телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Свойство номера телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                Set(ref _phoneNumber, value);
            }
        }

        /// <summary>
        /// Поле электронной почты контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Свойство электронной почты контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                Set(ref _email, value);
            }
        }

        // -------------------- Конструкторы --------------------

        /// <summary>
        /// Конструктор контакта с параметрами.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Contact(string name = "", string phoneNumber = "", string email = "")
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // ---------------- Методы ----------------------

        /// <summary>
        /// Метод объявления об изменении свойств.
        /// </summary>
        /// <param name="prop"></param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

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
    }
}
