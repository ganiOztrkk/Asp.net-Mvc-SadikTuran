using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using BlogMvcApp.Models;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogContext _context = new BlogContext();
        public ActionResult Index()
        {
            var blogs = _context.Blogs
                .Where(x => x.Status == true && x.Homepage == true)
                .Select(y =>
                    new BlogViewModel()
                    {
                        Id = y.Id,
                        Title = y.Title.Length>50? y.Title.Substring(0,50)+"...":y.Title,
                        Description = y.Description,
                        PublishDate = y.PublishDate,
                        Image = y.Image
                    });
            return View(blogs.ToList());
        }
    }
}