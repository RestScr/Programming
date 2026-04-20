using System.Globalization;
using System.Windows.Controls;

namespace View.ViewModel.ValidationRules;

/// <summary>
/// Класс правила валидации для номера телефона контакта.
/// </summary>
public class PhoneRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        return ValidationResult.ValidResult;
    }
}
