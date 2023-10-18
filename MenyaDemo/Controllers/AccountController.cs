using MenyaDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenyaDemo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            if (user.UserName == "Hamada" && user.Password == "456")
                return RedirectToAction("Index","Employee");
            return View(user);
        }
    }
}
