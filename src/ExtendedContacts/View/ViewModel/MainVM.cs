using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel;

/// <summary>
/// Класс ViewModel.
/// </summary>
public partial class MainVM : ObservableObject
{
    /// <summary>
    /// Поле выбранного контакта.
    /// </summary>
    [ObservableProperty]
    private Contact? _selectedContact;

    /// <summary>
    /// Поле выбранного контакта.
    /// </summary>
    private ContactVM _contactViewModel;

    /// <summary>
    /// Поле коллекции контактов.
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<Contact> _contacts;

    /// <summary>
    /// Поле текста текстового поля фильтра.
    /// </summary>
    [ObservableProperty]
    private string _textFilter;

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
    /// Свойство подсписка полученных элементов по фильтру.
    /// </summary>
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

        ContactViewModel.PropertyChanged += ContactViewModel_PropertyChanged;
    }

    /// <summary>
    /// Функция, которая исполняется на изменении текста в строке
    /// поиска контактов.
    /// </summary>
    /// <param name="value"></param>
    partial void OnTextFilterChanged(string value)
    {
        ContactsView.Refresh();
    }

    /// <summary>
    /// Функция, которая выполняется после задания свойства выбранного контакта.
    /// </summary>
    /// <param name="oldValue"> Старое значение. </param>
    /// <param name="newValue"> Новое значение. </param>
    partial void OnSelectedContactChanged(Contact? oldValue, Contact? newValue)
    {
        if (oldValue == newValue)
        {
            return;
        }

        if (oldValue != newValue)
        {
            ContactViewModel.EditMode = false;
        }

        if (newValue != null)
        {
            ContactViewModel.EditingContact = (Contact)(newValue.Clone());
        }
        else
        {
            ContactViewModel.EditingContact = null;
        }
    }

    /// <summary>
    /// Функция для включения кнопки редактирования или удаления.
    /// </summary>
    /// <returns> Можно ли редактировать контакт - true или false. </returns>
    private bool CanEdit()
    {
        return SelectedContact != null;
    }

    /// <summary>
    /// Функция проверки окна редактирования контакта на состояние редактирования.
    /// </summary>
    /// <returns> true или false. </returns>
    private bool IsOnEditMode()
    {
        return ContactViewModel.EditMode;
    }

    /// <summary>
    /// Функция добавления нового контакта.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр. </param>
    [RelayCommand]
    public void AddContact(object? parameter)
    {
        SelectedContact = null;
        SelectedContact = new Contact();

        ContactViewModel.EditMode = true;
    }

    /// <summary>
    /// Функция редактирования контакта.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр для команды. </param>
    [RelayCommand(CanExecute = nameof(CanEdit))]
    public void EditContact(object? parameter)
    {
        ContactViewModel.EditMode = true;
    }

    /// <summary>
    /// Функция удаления выбранного контакта.
    /// </summary>
    /// <param name="parameter"> Параметр команды. </param>
    [RelayCommand(CanExecute = nameof(CanEdit))]
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
    /// Функция добавления нового контакта в список.
    /// </summary>
    /// <param name="appliedContact"> Дополнительный параметр для команды. </param>
    [RelayCommand(CanExecute = nameof(IsOnEditMode))]
    public void ApplyContact(Contact? appliedContact)
    {
        if (Contacts.Contains(appliedContact))
        {
            int id = Contacts.IndexOf(appliedContact);
            Contacts[id] = appliedContact;
        }
        else
        {
            Contacts.Add(appliedContact);
        }

        SelectedContact = null;
        SelectedContact = appliedContact;

        ContactViewModel.EditMode = false;
        Serializer.Save(Contacts);
    }

    /// <summary>
    /// Метод выгрузки списка контактов.
    /// </summary>
    private void LoadContactlist()
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

    /// <summary>
    /// Фукнция проброса объявления об изменении внутреннего состояния объекта ContactVM.
    /// </summary>
    /// <param name="sender"> Объект, вызвавший событие. </param>
    /// <param name="eventArgs"> Аргументы измененных свойств. </param>
    private void ContactViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs eventArgs)
    {
        if (eventArgs.PropertyName == nameof(ContactViewModel.EditMode))
        {
            ApplyContactCommand.NotifyCanExecuteChanged();
        }
    }
}
