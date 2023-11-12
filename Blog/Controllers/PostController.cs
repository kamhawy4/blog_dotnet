using Blog.Models;
using Blog.Data;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    public class PostController : Controller
    {

        private readonly BLOGDbContext _context;

        public PostController(BLOGDbContext context)
        {
            _context = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = _context.Posts.ToList();

            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Edit()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Posts model)
        {
            if (ModelState.IsValid)
            {
                _context.Posts.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Posts model)
        {
            if (ModelState.IsValid)
            {
                _context.Posts.Update(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }


        public IActionResult Delete(int? id)
        {
            var result = _context.Posts.Find(id);

            if (result != null)
            {
                _context.Posts.Remove(result);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));

        }


    }
}

