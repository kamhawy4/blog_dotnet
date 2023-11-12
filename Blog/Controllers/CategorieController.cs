using Blog.Models;
using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class CategorieController : Controller
    {
        private readonly BLOGDbContext _context;

        public CategorieController(BLOGDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            _context.Categories.ToList();

            return View();
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
        public IActionResult Create(Categories model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(model);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public IActionResult Edit(Categories model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(model);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Categories model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Remove(model);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index)); ;
        }

    }
}

