using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using View.Model.Services;

namespace View.ViewModel;

/// <summary>
/// Класс ViewModel.
/// </summary>
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Событие уведомления об изменении свойств.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Метод объявления об изменении свойств.
    /// </summary>
    /// <param name="prop"></param>
    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// Свойство объекта сериализатора.
    /// </summary>
    public ContactSerializer Serializer { get; private set; } = new ContactSerializer();

    /// <summary>
    /// Поле команды сохранения контакта.
    /// </summary>
    private RelayCommand _saveCommand;

    /// <summary>
    /// Поле команды выгрузки.
    /// </summary>
    private RelayCommand _loadCommand;

    /// <summary>
    /// Поле выбранного контакта.
    /// </summary>
    private Contact _selectedContact;

    /// <summary>
    /// Свойство команды сохранения контакта.
    /// </summary>
    public RelayCommand SaveCommand
    {
        get => _saveCommand;
        private set
        {
            Set(ref _saveCommand, value, nameof(SaveCommand));
        }
    }

    /// <summary>
    /// Свойство команды выгрузки.
    /// </summary>
    public RelayCommand LoadCommand
    {
        get => _loadCommand;
        private set
        {
            Set(ref _loadCommand, value, nameof(LoadCommand));
        }
    }

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

    /// <summary>
    /// Стандартный инициализирующий конструтор разделения ViewModel.
    /// </summary>
    public MainVM()
    {
        SelectedContact = new Contact();

        LoadCommand = new RelayCommand(LoadContact);
        SaveCommand = new RelayCommand(SaveContact);
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

    /// <summary>
    /// Функция выгрузки контакта из файла.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр команды. </param>
    public void LoadContact(object? parameter)
    {
        SelectedContact = Serializer.Load();
    }

    /// <summary>
    /// Функция загрузки контакта в файл.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр команды. </param>
    public void SaveContact(object? parameter)
    {
        Serializer.Save(SelectedContact);
    }
}
