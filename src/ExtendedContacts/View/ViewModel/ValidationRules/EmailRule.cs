using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace View.ViewModel.ValidationRules;

/// <summary>
/// Класс правила валидации для почты.
/// </summary>
public class EmailRule : ValidationRule
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="value"> Введенное значение. </param>
    /// <param name="cultureInfo"> <inheritdoc/> </param>
    /// <returns> <inheritdoc/> </returns>
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        string email = (string)value;
        string emailRegexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        if (!Regex.IsMatch(email, emailRegexPattern))
        {
            return new ValidationResult(false, $"Email must be of pattern youremail@email.com");
        }

        if (email.Length > 100)
        {
            return new ValidationResult(false, $"Email must be of characters less than 100");
        }

        
        return ValidationResult.ValidResult;
    }
}
