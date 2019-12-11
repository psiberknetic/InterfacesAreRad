using CMS.Common;
using DonkeySoftContactManagement;
using NateSoftContactProviders.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NateSoftContactProviders
{
    public class DonkeySoftContactProvider : IContactProvider
    {
        ContactService _contactService = new ContactService();
        IEnumerable<CMS.Common.Contact> IContactProvider.Contacts
        {
            get
            {
                var contacts = _contactService.GetCustomers
                    .Union(_contactService.GetEmployees)
                    .Union(_contactService.GetInvestors);
                return contacts.Select(DonkeySoftToNewContactConverter.Convert);
            }
        }
    }
}
