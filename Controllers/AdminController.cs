using Blog_Site.Data;
using Blog_Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Site.Controllers
{
    public class AdminController : Controller
    {
        AppDbContext Db;

        public AdminController(AppDbContext _Db)
        {
            Db=_Db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPost(Post myPost)
        {
            Db.tbl_Post.Add(myPost);
            Db.SaveChanges();
            return View();
        }

        public IActionResult AllPosts()
        {
            var myAllPosts = Db.tbl_Post.ToList();
            return View(myAllPosts);
        }
    }
}
