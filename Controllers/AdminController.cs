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

        public IActionResult DeletePost(int Id)
        {
            var PosttoDelete = Db.tbl_Post.Find(Id);
            if(PosttoDelete!=null)
            {
                Db.Remove(PosttoDelete);
                Db.SaveChanges();
            }
            return RedirectToAction("AllPosts", "Admin");
        }

        public IActionResult UpdatePost(int Id)
        {
            var PostToUpdate = Db.tbl_Post.Find(Id);
            return View(PostToUpdate);
        }

        [HttpPost]
        public IActionResult UpdatePost(Post post)
        {
           Db.tbl_Post.Update(post);
            Db.SaveChanges();
            return RedirectToAction("AllPosts", "Admin");

        }
    }
}
