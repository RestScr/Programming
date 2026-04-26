using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using View.Converters;

namespace View.Controls;

/// <summary>
/// Логика взаимодействия для ContactControl.xaml
/// </summary>
public partial class ContactControl : UserControl
{
    /// <summary>
    /// Соответствующее свойство валидации текстовых полей элемента.
    /// </summary>
    public static readonly DependencyProperty IsValidProperty = DependencyProperty.Register(
        nameof(IsValid),
        typeof(bool),
        typeof(ContactControl),
        new FrameworkPropertyMetadata(null)
    );

    /// <summary>
    /// Свойство получения успеха валидации поля.
    /// </summary>
    public bool IsValid
    {
        get => (bool)GetValue(IsValidProperty);
        set => SetValue(IsValidProperty, value);
    }

    /// <summary>
    /// Конструктор по умолчанию.
    /// </summary>
    public ContactControl()
    {
        InitializeComponent();

        MultiBinding multiBinding = new MultiBinding() 
        { 
            Converter = new ValidationConverter() 
        };

        TextBox nameTextBox = (TextBox)FindName("NameTextBox");
        TextBox phoneNumberTextBox = (TextBox)FindName("PhoneNumberTextBox");
        TextBox emailTextBox = (TextBox)FindName("EmailTextBox");

        multiBinding.Bindings.Add(new Binding("(Validation.HasError)")
        {
            Source = nameTextBox
        });

        multiBinding.Bindings.Add(new Binding("(Validation.HasError)")
        {
            Source = phoneNumberTextBox
        });

        multiBinding.Bindings.Add(new Binding("(Validation.HasError)")
        {
            Source = emailTextBox
        });

        SetBinding(IsValidProperty, multiBinding);
    }
}
