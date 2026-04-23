using System.Diagnostics;

namespace View.Model.Services;

/// <summary>
/// Класс с преобразованием строк в нужный формат.
/// </summary>
public class StringFormatter
{
    /// <summary>
    /// Функция преобразования строки в номер телефона.
    /// </summary>
    /// <param name="phoneNumber"> Неотформатированная строка </param>
    public string ConvertIntoPhoneNumber(string phoneNumber)
    {
        Debug.WriteLine("Formating...");
        string digitsString = String.Empty;

        // Флаг, который отмечает, записана ли исходная страка с плюсом в начале
        bool specialFormat = true;

        for (int i = 0; i < phoneNumber.Length; i++)
        {
            if (digitsString.Length == 11)
            {
                break;
            }

            if (phoneNumber[i] == '+')
            {
                specialFormat = false;
            }

            if (Char.IsDigit(phoneNumber[i]))
            {
                digitsString += phoneNumber[i];
            }
        }

        string newPhoneNumber = "+";

        int offset = 0;
        int digitsCount = digitsString.Length;

        try
        {
            if (specialFormat)
            {
                int startDigit = Math.Abs(Convert.ToInt32(digitsString.Substring(offset++, Math.Min(digitsCount - offset, 1))) - 1);
                newPhoneNumber += $"{startDigit} ";
            }
            else
            {
                newPhoneNumber += $"{digitsString.Substring(offset++, Math.Min(digitsCount - offset, 1))} ";
            }

            newPhoneNumber += $"({digitsString.Substring(offset, Math.Min(digitsCount - offset, 3))}) ";
            offset += 3;

            newPhoneNumber += $"{digitsString.Substring(offset, Math.Min(digitsCount - offset, 3))}-";
            offset += 3;
            newPhoneNumber += $"{digitsString.Substring(offset, Math.Min(digitsCount - offset, 2))}-";
            offset += 2;
            newPhoneNumber += $"{digitsString.Substring(offset, Math.Min(digitsCount - offset, 2))}";
            offset += 2;
        }
        catch (ArgumentOutOfRangeException exception)
        {
            return newPhoneNumber;
        }

        return newPhoneNumber;
    }
}
