using InternalLegacySystem;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagementSystem.Controllers
{
    public class ContactsController : Controller
    {
        private ContactManager _contactManager;

        public ContactsController()
        {
            _contactManager = new ContactManager();
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View(_contactManager.GetContacts());
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [ViewData]
        public string Provider => _contactManager.GetType().FullName;
    }
}