using CMS.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NateSoftContactProviders.Converters
{
    public static class LegacyToNewContactConverter
    {
        public static CMS.Common.Contact Convert(InternalLegacySystem.Contact contact)
        {
            var convertedContact = new CMS.Common.Contact();
            convertedContact.FirstName = contact.ContactName.FirstName;
            convertedContact.MiddleName = contact.ContactName.MiddleName;
            convertedContact.LastName = contact.ContactName.LastName;
            convertedContact.Email = contact.Email;
            //... and more


            return convertedContact;
        }
    }
}
