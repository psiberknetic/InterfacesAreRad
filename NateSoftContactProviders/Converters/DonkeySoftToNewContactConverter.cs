using CMS.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NateSoftContactProviders.Converters
{
    public class DonkeySoftToNewContactConverter
    {
        public static CMS.Common.Contact Convert(DonkeySoftContactManagement.Contact contact)
        {
            var convertedContact = new CMS.Common.Contact();
            var parsedName = NameUtilities.ParseName(contact.Name);

            convertedContact.FirstName = parsedName.First;
            convertedContact.MiddleName = parsedName.Middle;
            convertedContact.LastName = parsedName.Last;
            convertedContact.Email = contact.Email;
            //... and more


            return convertedContact;
        }
    }
}
