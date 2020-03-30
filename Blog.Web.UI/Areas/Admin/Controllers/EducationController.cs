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
    public class EducationController : Controller
    {
        KadirDincComContext _context;

        public EducationController(KadirDincComContext kadirDincComContext)
        {
            _context = kadirDincComContext;
        }

        public IActionResult Index()
        {
            return View(_context.Educations.Where(x => x.IsDeleted == false).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                if (education.Status == true)
                {
                    education.DateOfFinish = null;
                }

                var addedEducation = new Education
                {
                    SchoolName = education.SchoolName,
                    SectionName = education.SectionName,
                    DateOfStart = education.DateOfStart,
                    DateOfFinish = education.DateOfFinish,
                    IsDeleted = false,
                    EditDate = education.EditDate,
                    Status = education.Status
                };
                _context.Educations.Add(addedEducation);
                _context.SaveChanges();
                return RedirectToAction("Index");
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
                return View();
            }

            var editEducation = _context.Educations.Where(x => x.ID == id).FirstOrDefault();
            return View(editEducation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Education education)
        {
            if (id != education.ID)
            {
                return View();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                _context.Educations.Update(education);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deletedEducation = _context.Educations.Where(x => x.ID == id).FirstOrDefault();
            return View(deletedEducation);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletedConfirm(int id)
        {
            try
            {
                var deletedEducation = _context.Educations.Find(id);
                deletedEducation.IsDeleted = true;
                _context.Educations.Update(deletedEducation);
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