using CMS.Common;
using InternalLegacySystem;
using System;
using System.Collections.Generic;

namespace NateSoftContactProviders
{
    public class LegacyContactProvider : IContactProvider
    {
        ContactManager _contactManager = new ContactManager();
        public IEnumerable<CMS.Common.Contact> Contacts => throw new NotImplementedException();
    }
}
