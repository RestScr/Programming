using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model;

/// <summary>
/// Класс редактируемого контакта, созданный исключительно
/// для ViewModel
/// </summary>
internal class EditableContact : Contact
{
    private bool _isEditable;

    public bool IsEditable
    {
        get => _isEditable;
        set
        {
            _isEditable = value;
        }
    }

    public EditableContact(Contact contact) : 
        base(contact.Name, contact.PhoneNumber, contact.Email)
    {
        IsEditable = true;
    }
}
