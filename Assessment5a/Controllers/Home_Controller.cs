using Assessment5a.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment5a.Controllers
{
    public class Home_Controller : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Welcome(Login login)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            if (!(login.Password == "opensesame"))
            {
                return RedirectToAction("WrongPassword");
            }
            ViewBag.Name = login.Name.ToUpper();
            ViewBag.Length = login.Name.Length;
            return View();
        }
   
        public IActionResult WrongPassword()
        {
            return View();
        }
    }
}