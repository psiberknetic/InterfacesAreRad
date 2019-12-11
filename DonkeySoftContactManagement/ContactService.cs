using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonkeySoftContactManagement
{
    public class ContactService
    {
        private readonly IEnumerable<Contact> _contacts = new[]{
            new Contact{
                Name = "Nydia Johannes McFarland",
                Email = "corbin_keebl@hotmail.com",
                HomeAddressLine1 = "3117 Thomas Street",
                HomeCity = "Northbrook",
                HomeState = "IL",
                HomeZip = "60062",
                HomePhone = "847-562-5747",
                WorkAddress1 = "4196 Vine Street",
                WorkCity = "Northbrook",
                WorkState = "IL",
                WorkZip = "60062",
                WorkPhone = "847-651-6668",
                IsCustomer = true,
                IsEmployee = false,
                IsInvestor = false
            },
            new Contact{
                Name = "Kenny Vivian Paige",
                Email = "chadrick.kirl@gmail.com",
                HomeAddressLine1 = "3896 Thomas Street",
                HomeCity = "Evanston",
                HomeState = "IL",
                HomeZip = "60219",
                HomePhone = "847-492-8600",
                WorkAddress1 = "4196 Vine Street",
                WorkCity = "Northbrook",
                WorkState = "IL",
                WorkZip = "60062",
                WorkPhone = "847-644-1601",
                IsCustomer = true,
                IsEmployee = false,
                IsInvestor = false
            },
            new Contact{
                Name = "William Claude Schippers",
                Email = "chester2006@yahoo.com",
                HomeAddressLine1 = "4513 Mulberry Street",
                HomeCity = "Houston",
                HomeState = "TX",
                HomeZip = "77036",
                HomePhone = "936-649-2493",
                WorkAddress1 = "3834 Werninger Street",
                WorkCity = "Houston",
                WorkState = "TX",
                WorkZip = "77036",
                WorkPhone = "832-977-2312",
                IsCustomer = false,
                IsEmployee = false,
                IsInvestor = true
            },
        };

        public IEnumerable<Contact> GetCustomers => _contacts.Where(c => c.IsCustomer);
        public IEnumerable<Contact> GetEmployees => _contacts.Where(c => c.IsEmployee);
        public IEnumerable<Contact> GetInvestors => _contacts.Where(c => c.IsInvestor);
    }
}
