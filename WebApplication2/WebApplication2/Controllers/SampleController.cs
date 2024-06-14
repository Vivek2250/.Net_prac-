using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class SampleController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
        public string FirstName()
        {
            return "Rengoku";
        }
        public string LastName()
        {
            return "Kyojuro";
        }
        public string Anime()
        {
            return "Demon Slayer";
        }
        public string Rank()
        {
            return "Hashira";
        }
    }
}
