using System.Windows;
using System.Windows.Controls;
using View.Controls;


namespace View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// Стандартный конструктор главного окна.
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = new MainVM();

        ContactControl contactControl = (ContactControl)FindName("ContactControl");
        TextBox phoneNumberTextBox = (TextBox)contactControl.FindName("PhoneNumberTextBox");

        DataObject.AddPastingHandler(phoneNumberTextBox, ((MainVM)this.DataContext).ContactViewModel.OnPasting);
    }
}