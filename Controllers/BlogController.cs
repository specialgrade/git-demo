using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using git_demo.Models;

namespace git_demo.Controllers
{
    public class BlogController : Controller
    {
        private static List<Post> posts = new List<Post>
        {
            new Post { Id = 1, Title = "First Post", Content = "Ikaw yung nag ShOpLiFfTt", Author = "Alyssa" },
            new Post { Id = 2, Title = "Second Post", Content = "Six Sevennnn", Author = "Alyssa" }
        };

        public IActionResult Index()
        {
            return View(posts);
        }

        public IActionResult Details(int id)
        {
            var post = posts.FirstOrDefault(p => p.Id == id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }
    }
}

