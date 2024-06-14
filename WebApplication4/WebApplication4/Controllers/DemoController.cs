using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
