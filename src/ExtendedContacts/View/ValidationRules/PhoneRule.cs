using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace View.ValidationRules;

/// <summary>
/// Класс правила валидации для номера телефона контакта.
/// </summary>
public class PhoneRule : ValidationRule
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cultureInfo"></param>
    /// <returns> <inheritdoc/> </returns>
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        string phoneNumber = (string)value;
        string phoneNumberPattern = @"^\+[0-9]{1,3}\s\([0-9]{3}\)\s[0-9]{3}-[0-9]{2}-[0-9]{2}$";

        if (!Regex.IsMatch(phoneNumber, phoneNumberPattern))
        {
            return new ValidationResult(false, $"Phone Number must be of pattern +7 (999) 999-99-99");
        }

        if (phoneNumber.Length > 100)
        {
            return new ValidationResult(false, $"Phone Number must be length of 100");
        }

        return ValidationResult.ValidResult;
    }
}
