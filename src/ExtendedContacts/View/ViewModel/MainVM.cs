using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие уведомления об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Функция, вызывающее событие изменения свойства.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns> Всегда true. </returns>
        public bool OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }

        /// <summary>
        /// Поле выбранного контакта.
        /// </summary>
        private Contact _selectedContact = new Contact();

        /// <summary>
        /// Свойство выбранного контакта.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                Set(ref _selectedContact, value, nameof(SelectedContact));
            }
        }

        /// <summary>
        /// Поле коллекции контактов.
        /// </summary>
        private ObservableCollection<Contact> _contactList = new ObservableCollection<Contact>();

        /// <summary>
        /// Свойство коллекции контактов.
        /// </summary>
        public ObservableCollection<Contact> ContactList
        {
            get => _contactList;
            set
            { 
                _contactList = value; 
            }
        }


        /// <summary>
        /// Функция задания нового уникального значения полю с уведомлением.
        /// </summary>
        /// <typeparam name="Type"> Тип поля. </typeparam>
        /// <param name="fieldToSet"> Ссылка на поле, которому нужно задать значение. </param>
        /// <param name="setValue"> Значение для задания. </param>
        /// <param name="propertyName"> Имя свойства, в котором задается значение. </param>
        /// <returns> Является ли значение новым для поля. (true - да, false - нет). </returns>
        public bool Set<Type>(ref Type fieldToSet, Type setValue, [CallerMemberName] string propertyName = null)
        {
            if (Equals(fieldToSet, setValue))
            {
                return false;
            }
            else
            {
                fieldToSet = setValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
        }
    }
}
