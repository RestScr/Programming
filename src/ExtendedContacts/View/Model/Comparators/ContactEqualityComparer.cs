using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Comparators
{
    class ContactEqualityComparer : IEqualityComparer<Contact>
    {
        public bool Equals(Contact? x, Contact? y)
        {
            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] Contact obj)
        {
            return obj.GetHashCode();
        }
    }
}
