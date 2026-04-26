using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using Model;


namespace View.ViewModel;

/// <summary>
/// Класс управления контактом.
/// </summary>
public partial class ContactVM : ObservableObject
{
    /// <summary>
    /// Поле редактируемого контакта.
    /// </summary>
    [ObservableProperty]
    private Contact _editingContact;

    /// <summary>
    /// Флажок редактирования.
    /// </summary>
    [ObservableProperty]
    private bool _editMode;

    /// <summary>
    /// Закрытое свойство форматора строк.
    /// </summary>
    private StringFormatter Formatter { get; set; } = new StringFormatter();

    /// <summary>
    /// Функция преформатирования вводимого текста в текстбокс с номером телефона.
    /// </summary>
    /// <param name="sender"> Инициализатор события. </param>
    /// <param name="eventArgs"> Аргументы вставки. </param>
    public void OnPasting(object sender, DataObjectPastingEventArgs eventArgs)
    {
        string pastedText = (string)eventArgs.DataObject.GetData(typeof(string));

        DataObject preformatedText = new DataObject();
        preformatedText.SetData(DataFormats.Text, Formatter.ConvertIntoPhoneNumber(pastedText));

        eventArgs.DataObject = preformatedText;
    }
}
