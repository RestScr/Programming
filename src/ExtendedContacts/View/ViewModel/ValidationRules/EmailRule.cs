using System.Globalization;
using System.Windows.Controls;

namespace View.ViewModel.ValidationRules;

/// <summary>
/// Класс правила валидации для почты.
/// </summary>
public class EmailRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        return ValidationResult.ValidResult;
    }
}
