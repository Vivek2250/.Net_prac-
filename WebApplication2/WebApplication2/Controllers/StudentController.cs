using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "I am a Trainer";
        }
        public string GetRollNumber()
        {
            return "21";
        }
        public string Name()
        {
            return "Abdullah";
        }
    }
}
