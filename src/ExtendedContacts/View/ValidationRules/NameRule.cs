using System.Globalization;
using System.Windows.Controls;

namespace View.ValidationRules;

/// <summary>
/// Класс правила валидации для имени контакта.
/// </summary>
public class NameRule : ValidationRule
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cultureInfo"></param>
    /// <returns> <inheritdoc/> </returns>
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        string name = (string)value;
        if (name.Length > 100)
        {
            return new ValidationResult(false, $"Name property must be less than 100 characters.");
        }
        if (name.Length <= 2)
        {
            return new ValidationResult(false, $"Name property must be higher than 2 characters.");
        }

        return ValidationResult.ValidResult;
    }
}
