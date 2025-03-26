using Microsoft.AspNetCore.Mvc;

namespace MVC_DEMO1.Controllers
{
    public class AcountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
