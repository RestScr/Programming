using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
    /// Поле, хранящее статус режима редактирования.
    /// </summary>
    private bool _editMode = false;

    /// <summary>
    /// Поле коллекции контактов.
    /// </summary>
    private ObservableCollection<Contact> _contactList;

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
            if ((value != SelectedContact) && EditMode)
            {
                EditMode = false;
                SelectedContact?.RollBack();
            }

            if (value == null)
            {
                EditCommand.IsExecutable = false;
                RemoveCommand.IsExecutable = false;
            }
            else
            {
                EditCommand.IsExecutable = true;
                RemoveCommand.IsExecutable = true;
            }

            Set(ref _selectedContact, value, nameof(SelectedContact));
        }
    }

    /// <summary>
    /// Свойство статуса режима редактирования.
    /// </summary>
    public bool EditMode
    {
        get => _editMode;
        set 
        {
            ApplyCommand.IsExecutable = value;

            Set(ref _editMode, value, nameof(EditMode));
        }
    }

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
    /// Свойство команды добавления.
    /// </summary>
    public RelayCommand AddCommand
    {
        get => _addCommand;
        init
        {
            _addCommand = value;
        }
    }

    /// <summary>
    /// Свойство команды добавления нового контакта.
    /// </summary>
    public RelayCommand ApplyCommand
    {
        get => _applyCommand;
        set 
        { 
            _applyCommand = value; 
        }
    }

    /// <summary>
    /// Свойство команды редактирования.
    /// </summary>
    public RelayCommand EditCommand
    {
        get => _editCommand;
        set 
        { 
            _editCommand = value; 
        }
    }

    /// <summary>
    /// Свойство команды удаления.
    /// </summary>
    public RelayCommand RemoveCommand
    {
        get => _removeCommand;
        set 
        { 
            _removeCommand = value; 
        }
    }

    /// <summary>
    /// Стандартный конструктор MainVM.
    /// </summary>
    public MainVM()
    {
        AddCommand = new RelayCommand(AddContact);
        ApplyCommand = new RelayCommand(ApplyContact, false);
        EditCommand = new RelayCommand(EditContact);
        RemoveCommand = new RelayCommand(RemoveContact);
        SelectedContact = null;

        LoadContactlist();
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

        EditMode = true;
    }

    /// <summary>
    /// Функция редактирования контакта.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр для команды. </param>
    public void EditContact(object? parameter)
    {
        EditMode = true;
    }

    /// <summary>
    /// Функция добавления нового контакта в список.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр для команды. </param>
    public void ApplyContact(object? parameter)
    {
        if (!ContactList.Contains(SelectedContact))
        {
            ContactList.Add(SelectedContact);
        }

        SelectedContact.Commit();
        EditCommand.IsExecutable = true;
        RemoveCommand.IsExecutable = true;

        EditMode = false;
        Serializer.Save(ContactList);
    }

    /// <summary>
    /// Функция удаления выбранного контакта.
    /// </summary>
    /// <param name="parameter"> Параметр команды. </param>
    public void RemoveContact(object? parameter)
    {
        int selectedIndex = ContactList.IndexOf(SelectedContact) - 1;
        ContactList?.Remove(SelectedContact);

        if (selectedIndex >= 0)
        {
            SelectedContact = ContactList[selectedIndex];
        }
        else
        {
            SelectedContact = null;
        }

        Serializer.Save(ContactList);
    }

    /// <summary>
    /// Метод выгрузки списка контактов.
    /// </summary>
    public void LoadContactlist()
    {
        ContactList = Serializer.Load();
    }
}
