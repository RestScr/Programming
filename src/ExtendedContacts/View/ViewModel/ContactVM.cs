using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using View.Model;
using View.Model.Services;

namespace View.ViewModel;

/// <summary>
/// Класс управления контактом.
/// </summary>
public class ContactVM : INotifyPropertyChanged
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Поле редактируемого контакта.
    /// </summary>
    private Contact _editingContact;

    /// <summary>
    /// Флажок редактирования.
    /// </summary>
    private bool _editMode;

    /// <summary>
    /// Свойство редактируемого контакта.
    /// </summary>
    public Contact EditingContact
    {
        get => _editingContact;
        set
        {
            Set(ref _editingContact, value, nameof(EditingContact));
        }
    }

    /// <summary>
    /// Поле флажка редактирования.
    /// </summary>
    public bool EditMode
    {
        get => _editMode;
        set
        {
            Set(ref _editMode, value, nameof(EditMode));
        }
    }

    /// <summary>
    /// Закрытое свойство форматора строк.
    /// </summary>
    private StringFormatter Formatter { get; set; } = new StringFormatter();

    /// <summary>
    /// Функция правильного задания свойств.
    /// </summary>
    /// <typeparam name="Type"> Тип задаваемого свойства. </typeparam>
    /// <param name="fieldToSet"> Поле свойства. </param>
    /// <param name="setValue"> Задаваемое значение. </param>
    /// <param name="propertyName"> Имя свойства. </param>
    /// <returns> true. </returns>
    private bool Set<Type>(ref Type fieldToSet, Type setValue, [CallerMemberName] string propertyName = null)
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
    /// Функция преформатирования вводимого текста в текстбокс с номером телефона.
    /// </summary>
    /// <param name="sender"> Инициализатор события. </param>
    /// <param name="eventArgs"> Аргументы вставки. </param>
    public void OnPasting(object sender, DataObjectPastingEventArgs eventArgs)
    {
        Debug.WriteLine("Pasted text!");
        string pastedText = (string)eventArgs.DataObject.GetData(typeof(string));

        DataObject preformatedText = new DataObject();
        preformatedText.SetData(DataFormats.Text, Formatter.ConvertIntoPhoneNumber(pastedText));

        eventArgs.DataObject = preformatedText;
    }
}
