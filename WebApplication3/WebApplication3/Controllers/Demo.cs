using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class Demo : Controller
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
