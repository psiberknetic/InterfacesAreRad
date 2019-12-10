using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CMS.Common
{
    public class Contact
    {
        private ICollection<Address> _addresses = new Collection<Address>();
        private ICollection<PhoneNumber> _phoneNumbers = new Collection<PhoneNumber>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public IEnumerable<PhoneNumber> PhoneNumbers { get; }
        public IEnumerable<Address> Addresses { get; }
        public string Email { get; set; }
    }
}