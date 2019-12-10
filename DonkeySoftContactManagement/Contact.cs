using System;
using System.Collections.Generic;
using System.Text;

namespace DonkeySoftContactManagement
{
    public class Contact
    {
        public string Name { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string HomeAddressLine1 { get; set; }
        public string HomeAddressLine2 { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomeZip { get; set; }
        public string WorkAddress1 { get; set; }
        public string WorkAddress2 { get; set; }
        public string WorkCity { get; set; }
        public string WorkState { get; set; }
        public string WorkZip { get; set; }
        public string Email { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsInvestor { get; set; }
    }
}
