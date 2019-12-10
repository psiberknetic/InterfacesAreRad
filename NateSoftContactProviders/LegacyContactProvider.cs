using CMS.Common;
using InternalLegacySystem;
using NateSoftContactProviders.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NateSoftContactProviders
{
    public class LegacyContactProvider : IContactProvider
    {
        ContactManager _contactManager = new ContactManager();
        public IEnumerable<CMS.Common.Contact> Contacts =>
            _contactManager.GetContacts().Select(LegacyToNewContactConverter.Convert);
    }
}
