using System;
using System.Collections.Generic;
using System.Text;

namespace InternalLegacySystem
{
    public class ContactManager
    {
        public Name ContactName { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }
        public string Email { get; set; }
    }
}
