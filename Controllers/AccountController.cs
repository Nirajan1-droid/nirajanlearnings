using Microsoft.AspNetCore.Mvc;
using WIHTOUT_DOCK.Models;
 

namespace YourNamespace.Controllers
{
    public class AccountController : Controller
    {
        // GET: under Views/Account/Index.cshtml file is being returned for the View method.
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // Handle login logic here
            // For example, check credentials and authenticate user
            // Redirect to appropriate page on successful login
            return RedirectToAction("Index", "Account/Login");
        }
    }
}
