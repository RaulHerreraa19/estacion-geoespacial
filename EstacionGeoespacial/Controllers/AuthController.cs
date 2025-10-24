using Microsoft.AspNetCore.Mvc;

namespace EstacionGeoespacial.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
