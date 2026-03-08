using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private Contact _selectedContact;

        public Contact SelectedContact
        {
            get => _selectedContact;
            set 
            { 
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }
        public MainVM()
        {
            SelectedContact = new Contact("Rostislav", "804939393", "fsfsdfssdfdfsfds");
        }
    }
}
