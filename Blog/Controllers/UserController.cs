using System;
using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	public class UserController : Controller
    {
        private readonly BLOGDbContext _context;

        public UserController(BLOGDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = _context.Users.ToList();

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
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(User model)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Update(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }


        public IActionResult Delete(int? id)
        {
            var result = _context.Users.Find(id);

            if (result != null)
            {
                _context.Users.Remove(result);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));

        }
    }
}

