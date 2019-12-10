using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Common
{
    public interface IContactProvider
    {
        IEnumerable<Contact> Contacts { get; }
    }
}
