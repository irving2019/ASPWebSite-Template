using Microsoft.AspNetCore.Mvc;
using ASPWebSite.Models;

namespace ASPWebSite.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() //Contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact) 
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");


        }

    }
}
