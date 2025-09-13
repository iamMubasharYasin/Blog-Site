using Blog_Site.Data;
using Blog_Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Site.Controllers
{
  
    public class Home : Controller 
    {

        AppDbContext db; 

        public Home(AppDbContext _db) 
        {
            db= _db;
        }
        public IActionResult Index()
        {
            IEnumerable<Post> myPost = db.tbl_Post;
            return View(myPost);
        }

        public IActionResult Post()
        {
            return View();
        }
    }
}
