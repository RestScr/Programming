using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс ViewModel.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        // ------------------- События ------------------
        /// <summary>
        /// Событие уведомления об изменении свойств.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Метод объявления об изменении свойств.
        /// </summary>
        /// <param name="prop"></param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        // ----------------- Поля и свойства ------------------

        /// <summary>
        /// Свойство объекта сериализатора.
        /// </summary>
        public ContactSerializer Serializer { get; private set; } = new ContactSerializer();

        /// <summary>
        /// Поле команды сохранения контакта.
        /// </summary>
        private Command _saveCommand;

        /// <summary>
        /// Свойство команды сохранения контакта.
        /// </summary>
        public Command SaveCommand
        {
            get => _saveCommand;
            private set
            {
                _saveCommand = value;
            }
        }

        /// <summary>
        /// Поле команды выгрузки.
        /// </summary>
        private Command _loadCommand;

        /// <summary>
        /// Свойство команды выгрузки.
        /// </summary>
        public Command LoadCommand
        {
            get => _loadCommand;
            private set
            {
                _loadCommand = value;
            }
        }

        /// <summary>
        /// Поле выбранного контакта.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Свойство выбранного контакта.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set 
            {
                Set(ref _selectedContact, value);
            }
        }

        // -------------------- Конструкторы ----------------

        /// <summary>
        /// Стандартный инициализирующий конструтор разделения ViewModel.
        /// </summary>
        public MainVM()
        {
            SelectedContact = new Contact();

            LoadCommand = new Command(LoadContact);
        }

        // ------------------- Методы ------------------------

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

        /// <summary>
        /// Функция выгрузки контакта из файла.
        /// </summary>
        /// <param name="parameter"></param>
        public void LoadContact(object? parameter)
        {
            SelectedContact = Serializer.Load();
        }

        /// <summary>
        /// Функция загрузки контакта в файл.
        /// </summary>
        /// <param name="parameter"></param>
        public void SaveContact(object? parameter)
        {
            Serializer.Save(SelectedContact);
        }
    }
}
