using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Web.UI.Models.DatabaseContext;
using Blog.Web.UI.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        KadirDincComContext _context;

        public AboutController(KadirDincComContext kadirDincComContext)
        {
            _context = kadirDincComContext;
        }

        public IActionResult Index()
        {
            return View(_context.Abouts.Where(x => x.IsDeleted == false).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(About about)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var addedAbout = new About
            {
                Address = about.Address,
                Description = about.Description,
                Email = about.Email,
                Title = about.Title,
                EditDate = DateTime.Now,
                IsDeleted = false
            };

            try
            {
                _context.Abouts.Add(addedAbout);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            catch (Exception)
            {

            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editAbout = _context.Abouts.Where(x => x.ID == id).FirstOrDefault();
            return View(editAbout);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, About about)
        {
            if (id != about.ID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                _context.Abouts.Update(about);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            catch (Exception)
            {

            }
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deletedAbout = _context.Abouts.Where(x => x.ID == id).FirstOrDefault();
            return View(deletedAbout);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
           
            try
            {
                var deletedAbout = _context.Abouts.Find(id);
                deletedAbout.IsDeleted = true;
                _context.Abouts.Update(deletedAbout);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

            }
            return View();
        }

    }
}