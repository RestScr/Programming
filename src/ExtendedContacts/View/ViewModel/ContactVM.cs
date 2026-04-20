using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel;

/// <summary>
/// Класс управления контактом.
/// </summary>
public class ContactVM : INotifyPropertyChanged
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Поле редактируемого контакта.
    /// </summary>
    private Contact _editingContact;

    /// <summary>
    /// Флажок редактирования.
    /// </summary>
    private bool _editMode;

    /// <summary>
    /// Свойство редактируемого контакта.
    /// </summary>
    public Contact EditingContact
    {
        get => _editingContact;
        set
        {
            Set(ref _editingContact, value, nameof(EditingContact));
        }
    }

    /// <summary>
    /// Поле флажка редактирования.
    /// </summary>
    public bool EditMode
    {
        get => _editMode;
        set
        {
            Set(ref _editMode, value, nameof(EditMode));
        }
    }

    /// <summary>
    /// Функция правильного задания свойств.
    /// </summary>
    /// <typeparam name="Type"> Тип задаваемого свойства. </typeparam>
    /// <param name="fieldToSet"> Поле свойства. </param>
    /// <param name="setValue"> Задаваемое значение. </param>
    /// <param name="propertyName"> Имя свойства. </param>
    /// <returns> true. </returns>
    public bool Set<Type>(ref Type fieldToSet, Type setValue, [CallerMemberName] string propertyName = null)
    {
        if (Equals(fieldToSet, setValue))
        {
            return false;
        }
        else
        {
            fieldToSet = setValue;
            OnPropertyChanged(propertyName);
            return true;
        }
    }

    /// <summary>
    /// Функция, вызывающее событие изменения свойства.
    /// </summary>
    /// <param name="propertyName"> Название изменяемого свойства. </param>
    /// <returns> Всегда true. </returns>
    public bool OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        return true;
    }
}
