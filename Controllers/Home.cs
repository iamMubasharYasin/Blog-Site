using Microsoft.AspNetCore.Mvc;

namespace Blog_Site.Controllers
{

    public class Home : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }
    }
}
