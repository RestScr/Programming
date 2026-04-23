
using System.Diagnostics.CodeAnalysis;

namespace View.Model.Comparators;

public class ContactsNameComparer : IEqualityComparer<Contact>
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="contact1"></param>
    /// <param name="contact2"></param>
    /// <returns> <inheritdoc/></returns>
    public bool Equals(Contact? contact1, Contact? contact2)
    {
        if (contact1 == null && contact2 == null)
        {
            return true;
        }

        if (contact1 == null)
        {
            return false;
        }

        if (contact2 == null)
        {
            return false;
        }

        return contact1.Name == contact2.Name;
    }

    public int GetHashCode([DisallowNull] Contact obj)
    {
        throw new NotImplementedException();
    }
}
