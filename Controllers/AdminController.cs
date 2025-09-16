using Microsoft.AspNetCore.Mvc;

namespace Blog_Site.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
