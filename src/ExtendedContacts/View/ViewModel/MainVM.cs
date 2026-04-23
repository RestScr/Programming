using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using View.Model;
using View.Model.Services;
using View.ViewModel.Commands;

namespace View.ViewModel;

/// <summary>
/// Класс ViewModel.
/// </summary>
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Событие уведомления об изменении свойства.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Функция, вызывающее событие изменения свойства.
    /// </summary>
    /// <param name="propertyName"> Название изменяемого свойства. </param>
    /// <returns> Всегда true. </returns>
    public bool OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        return true;
    }

    /// <summary>
    /// Поле выбранного контакта.
    /// </summary>
    private Contact _selectedContact;

    /// <summary>
    /// Поле выбранного контакта.
    /// </summary>
    private ContactVM _contactViewModel;

    /// <summary>
    /// Поле команды добавления.
    /// </summary>
    private RelayCommand _addCommand;

    /// <summary>
    /// Поле команды добавления нового контакта.
    /// </summary>
    private RelayCommand _applyCommand;

    /// <summary>
    /// Поле команды редактирования.
    /// </summary>
    private RelayCommand _editCommand;

    /// <summary>
    /// Поле команды удаления.
    /// </summary>
    private RelayCommand _removeCommand;

    /// <summary>
    /// Поле коллекции контактов.
    /// </summary>
    private ObservableCollection<Contact> _contacts;

    private string _textFiler;

    /// <summary>
    /// Свойство сериализатора.
    /// </summary>
    public ContactListSerializer Serializer { get; private set; } = new ContactListSerializer();

    /// <summary>
    /// Свойство выбранного контакта.
    /// </summary>
    public Contact SelectedContact
    {
        get => _selectedContact;
        set
        {
            if (value == null)
            {
                ContactViewModel.EditMode = false;
                EditCommand.IsExecutable = false;
                RemoveCommand.IsExecutable = false;
            }
            else
            {
                ContactViewModel.EditMode = true;
                EditCommand.IsExecutable = true;
                RemoveCommand.IsExecutable = true;
            }

            if (value != _selectedContact)
            {
                ContactViewModel.EditMode = false;
                ApplyCommand.IsExecutable = false;
            }

            Set(ref _selectedContact, value, nameof(SelectedContact));
            if (SelectedContact != null)
            {
                ContactViewModel.EditingContact = (Contact)SelectedContact.Clone();
            }
            else
            {
                ContactViewModel.EditingContact = null;
            }
        }
    }

    /// <summary>
    /// Свойство выбранного контакта.
    /// </summary>
    public ContactVM ContactViewModel
    {
        get => _contactViewModel ?? (_contactViewModel = new ContactVM());
    }

    /// <summary>
    /// Свойство команды добавления.
    /// </summary>
    public RelayCommand AddCommand
    {
        get => _addCommand ?? (_addCommand = new RelayCommand(AddContact));
    }

    /// <summary>
    /// Свойство команды добавления нового контакта.
    /// </summary>
    public RelayCommand ApplyCommand
    {
        get => _applyCommand ?? (_applyCommand = new RelayCommand(ApplyContact, false));
    }

    /// <summary>
    /// Свойство команды редактирования.
    /// </summary>
    public RelayCommand EditCommand
    {
        get => _editCommand ?? (_editCommand = new RelayCommand(EditContact));
    }

    /// <summary>
    /// Свойство команды удаления.
    /// </summary>
    public RelayCommand RemoveCommand
    {
        get => _removeCommand ?? (_removeCommand = new RelayCommand(RemoveContact));
    }

    /// <summary>
    /// Свойство коллекции контактов.
    /// </summary>
    public ObservableCollection<Contact> Contacts
    {
        get => _contacts ?? (_contacts = new ObservableCollection<Contact>());
        set
        {
            _contacts = value;
        }
    }

    public string TextFilter
    {
        get => _textFiler;
        set
        {
            Set(ref _textFiler, value, nameof(TextFilter));

            ContactsView.Refresh();
        }
    }

    public ICollectionView ContactsView { get; init; }

    /// <summary>
    /// Стандартный конструктор MainVM.
    /// </summary>
    public MainVM()
    {
        SelectedContact = null;
        LoadContactlist();

        ContactsView = CollectionViewSource.GetDefaultView(Contacts);
        ContactsView.Filter = FilterContactsByName;
        ContactsView.Refresh();
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
            OnPropertyChanged(propertyName);
            return true;
        }
    }

    /// <summary>
    /// Функция добавления нового контакта.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр. </param>
    public void AddContact(object? parameter)
    {
        SelectedContact = new Contact();
        EditCommand.IsExecutable = false;
        RemoveCommand.IsExecutable = false;
        ApplyCommand.IsExecutable = true;

        ContactViewModel.EditMode = true;
    }

    /// <summary>
    /// Функция редактирования контакта.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр для команды. </param>
    public void EditContact(object? parameter)
    {
        ContactViewModel.EditMode = true;
        ApplyCommand.IsExecutable = true;
    }

    /// <summary>
    /// Функция добавления нового контакта в список.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр для команды. </param>
    public void ApplyContact(object? parameter)
    {
        Contact appliedContact = (Contact)parameter;

        if (!Contacts.Contains(appliedContact))
        {
            Contacts.Add(appliedContact);
        }
        else
        {
            int id = Contacts.IndexOf(appliedContact);
            Contacts[id] = appliedContact;
        }

        SelectedContact = appliedContact;

        ContactViewModel.EditMode = false;
        SetEditMode();
        Serializer.Save(Contacts);
    }

    /// <summary>
    /// Функция удаления выбранного контакта.
    /// </summary>
    /// <param name="parameter"> Параметр команды. </param>
    public void RemoveContact(object? parameter)
    {
        int selectedIndex = Contacts.IndexOf(SelectedContact) - 1;
        Contacts?.Remove(SelectedContact);

        if (selectedIndex >= 0)
        {
            SelectedContact = Contacts[selectedIndex];
        }
        else
        {
            SelectedContact = null;
        }

        Serializer.Save(Contacts);
    }

    /// <summary>
    /// Функция задания режима редактирования в ContactVM.
    /// </summary>
    private void SetEditMode()
    {
        if (ContactViewModel.EditMode)
        {
            ApplyCommand.IsExecutable = true;
        }
        else
        {
            ApplyCommand.IsExecutable = false;
        }
    }

    /// <summary>
    /// Метод выгрузки списка контактов.
    /// </summary>
    public void LoadContactlist()
    {
        Contacts = Serializer.Load();
    }

    /// <summary>
    /// Фильтрация контактов по введенному имени в поисковой строке контактов.
    /// </summary>
    /// <param name="parameter"> Введенное имя. </param>
    /// <returns> true или false </returns>
    private bool FilterContactsByName(object? parameter)
    {
        if (parameter == null)
        {
            return false;
        }

        Contact filteringContact = (Contact)parameter;

        return String.IsNullOrEmpty(TextFilter) || filteringContact.Name.Contains(TextFilter);
    }
}
