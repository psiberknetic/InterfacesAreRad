using System;
using System.Collections.Generic;
using System.Text;

namespace InternalLegacySystem
{
    public class ContactManager
    {
        readonly IEnumerable<Contact> _contacts = new[]{
            new Contact{
                ContactName = new Name{FirstName = "Steve", LastName = "Burroughs", MiddleName = "Alexander"},
                Email = "steve.burroughs@mindtrap.org",
                HomeAddress = new Address{Line1 = "123 Mulberry Way",
                                          City = "Tuscon",
                                          State = "AZ",
                                          Zip = "85716" },
                WorkPhone = "520-204-5432",
                HomePhone = "928-200-9617"
            },
            new Contact{
                ContactName = new Name{FirstName = "Kevin", LastName = "Brewer", MiddleName = "Michael"},
                Email = "maude1997@yahoo.com",
                HomeAddress = new Address{Line1 = "1837 Winding Way",
                                          City = "Providence",
                                          State = "RI",
                                          Zip = "02903"},
                WorkAddress = new Address{Line1 = "256 Winding Way",
                                          City = "Providence",
                                          State = "RI",
                                          Zip = "02903"},
                WorkPhone = "410-628-5815",
                HomePhone = "401-933-7613"
            },
            new Contact{
                ContactName = new Name{FirstName = "Carolyn", LastName = "Marrero", MiddleName = "Diane"},
                Email = "CarMar229@yahoo.com",
                HomeAddress = new Address{Line1 = "3452 Maxwell Farm Road",
                                          City = "Winchester",
                                          State = "VA",
                                          Zip = "22602"},
                WorkAddress = new Address{Line1 = "3142 Hurry St.",
                                          City = "Winchester",
                                          State = "VA",
                                          Zip = "22602"},
                WorkPhone = "540-247-9865",
                HomePhone = "434-203-6341"
            },
            new Contact{
                ContactName = new Name{FirstName = "Irene", LastName = "Forrest", MiddleName = "Chambers"},
                Email = "iforrest2@gmail.com",
                HomeAddress = new Address{Line1 = "2200 Wayback Lane",
                                          City = "White Plains",
                                          State = "NY",
                                          Zip = "10606"},
                WorkAddress = new Address{Line1 = "1761 Wayback Lane",
                                          City = "White Plains",
                                          State = "NY",
                                          Zip = "10606"},
                WorkPhone = "631-392-0750",
                HomePhone = "914-309-4919"
            },
            new Contact{
                ContactName = new Name{FirstName = "Christopher", LastName = "Harding", MiddleName = "Kristopher"},
                Email = "rubie_dar8@gmail.com",
                HomeAddress = new Address{Line1 = "3275 Murry Street",
                                          City = "Virginia Beach",
                                          State = "VA",
                                          Zip = "23462"},
                WorkPhone = "757-490-4971",
                HomePhone = "757-360-5790"
            },
        };

        public IEnumerable<Contact> GetContacts() => _contacts;
    }
}
