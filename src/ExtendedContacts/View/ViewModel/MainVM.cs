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
    /// Свойство сериализатора.
    /// </summary>
    public ContactListSerializer Serializer { get; private set; } = new ContactListSerializer();

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
    /// Стандартный конструктор MainVM.
    /// </summary>
    public MainVM()
    {
        ContactViewModel.SelectedContact = null;

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
        ContactViewModel.SelectedContact = new Contact();
        EditCommand.IsExecutable = false;
        RemoveCommand.IsExecutable = false;
        ApplyCommand.IsExecutable = true;

        ContactViewModel.EditMode = false;
    }

    /// <summary>
    /// Функция редактирования контакта.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр для команды. </param>
    public void EditContact(object? parameter)
    {
        ContactViewModel.EditMode = false;
    }

    /// <summary>
    /// Функция добавления нового контакта в список.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр для команды. </param>
    public void ApplyContact(object? parameter)
    {
        Contact appliedContact = (Contact) parameter;

        if (!ContactViewModel.Contacts.Contains(appliedContact))
        {
            ContactViewModel.Contacts.Add(appliedContact);
        }
        else
        {
            int id = ContactViewModel.Contacts.IndexOf(appliedContact);
            ContactViewModel.Contacts[id] = appliedContact;
        }

        ContactViewModel.SelectedContact = appliedContact;

        ContactViewModel.EditMode = false;
        Serializer.Save(ContactViewModel.Contacts);
    }

    /// <summary>
    /// Функция удаления выбранного контакта.
    /// </summary>
    /// <param name="parameter"> Параметр команды. </param>
    public void RemoveContact(object? parameter)
    {
        int selectedIndex = ContactViewModel.Contacts.IndexOf(ContactViewModel.SelectedContact) - 1;
        ContactViewModel.Contacts?.Remove(ContactViewModel.SelectedContact);

        if (selectedIndex >= 0)
        {
            ContactViewModel.SelectedContact = ContactViewModel.Contacts[selectedIndex];
        }
        else
        {
            ContactViewModel.SelectedContact = null;
        }

        Serializer.Save(ContactViewModel.Contacts);
    }

    /// <summary>
    /// Метод выгрузки списка контактов.
    /// </summary>
    public void LoadContactlist()
    {
        ContactViewModel.Contacts = Serializer.Load();
    }
}
