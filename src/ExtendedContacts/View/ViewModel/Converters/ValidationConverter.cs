using System.Globalization;
using System.Windows.Data;

namespace View.ViewModel.Converters;

/// <summary>
/// Класс конвертера валидации. Если значение во всех текстбоксах корректны.
/// </summary>
public class ValidationConverter : IMultiValueConverter
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="values"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns> <inheritdoc/></returns>
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        bool result = true;
        foreach (bool boolValue in values)
        {
            result = result && !boolValue;
        }

        return result;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetTypes"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns><inheritdoc/></returns>
    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        return new object[]{ value } ;
    }
}
