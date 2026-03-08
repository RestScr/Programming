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
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        ContactSerializer Serializer { get; set; } = new ContactSerializer();

        private SaveCommand _saveOperation;

        public SaveCommand SaveOperation
        {
            get
            {
                return _saveOperation ?? 
                    (
                        _saveOperation = new SaveCommand
                        (
                            obj => 
                            {
                                Serializer.Save(SelectedContact);
                            }
                        )
                    );
            }
        }

        private LoadCommand _loadOperation;

        public LoadCommand LoadOperation
        {
            get
            {
                return _loadOperation ??
                    (
                        _loadOperation = new LoadCommand
                        (
                            obj =>
                            {
                                SelectedContact = Serializer.Load();
                            }
                        )
                    );
            }
        }


        private Contact _selectedContact;

        public Contact SelectedContact
        {
            get => _selectedContact;
            set 
            {
                Set(ref _selectedContact, value);
            }
        }

        public MainVM()
        {
            SelectedContact = new Contact();
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
