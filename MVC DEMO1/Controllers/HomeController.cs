using Microsoft.AspNetCore.Mvc;

namespace MVC_DEMO1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Privacy()
        {

            return View();
        }
        public IActionResult AboutUs()
        {

            return View();
        }
    }
}
