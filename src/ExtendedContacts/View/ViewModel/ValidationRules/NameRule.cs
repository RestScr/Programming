using System.Globalization;
using System.Windows.Controls;

namespace View.ViewModel.ValidationRules;

/// <summary>
/// Класс правила валидации для имени контакта.
/// </summary>
public class NameRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        string name = (string)value;
        if (name.Length <= 100)
        {
            return ValidationResult.ValidResult;
        }

        return new ValidationResult(false, $"Name property must be less than 100 characters.");
    }
}
