using CMS.Common;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagementSystem.Controllers
{
    public class ContactsController : Controller
    {
        private IContactProvider _contactProvider;

        public ContactsController(IContactProvider contactProvider)
        {
            _contactProvider = contactProvider;
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View(_contactProvider.Contacts);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [ViewData]
        public string Provider => _contactProvider.GetType().FullName;
    }
}