using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult empFirstName()
        {
            return View();
        }
        public IActionResult empLastName()
        {
            return View();
        }
    }
}
