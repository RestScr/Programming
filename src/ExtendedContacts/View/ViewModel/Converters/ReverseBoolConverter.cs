using System.Globalization;
using System.Windows.Data;

namespace View.ViewModel.Converters;

/// <summary>
/// Конвертер, инвертирующий булевы значения.
/// </summary>
class ReverseBoolConverter : IValueConverter
{
    /// <summary>
    /// Метод преобразования для элемента.
    /// </summary>
    /// <param name="value"> Значение для преобразования. </param>
    /// <param name="targetType"> Элемент UI. </param>
    /// <param name="parameter"> Дополнительный параметр преобразования. </param>
    /// <param name="culture"></param>
    /// <returns> Инвертированное булево значение. </returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return !((bool)value);
    }

    /// <summary>
    /// Обратное инвертирование объекта.
    /// </summary>
    /// <param name="value"> Значение для обратного конвертирования. </param>
    /// <param name="targetType"> Элемент UI </param>
    /// <param name="parameter"> Дополнительный параметр. </param>
    /// <param name="culture"></param>
    /// <returns> Инвертированное буелво значение из элемента UI. </returns>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return !(bool)value;
    }
}
