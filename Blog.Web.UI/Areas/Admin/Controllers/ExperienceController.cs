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
    public class ExperienceController : Controller
    {
        private KadirDincComContext _context;
        public ExperienceController(KadirDincComContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Experiences.Where(x => x.IsDeleted == false).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                if (experience.Status == true)
                {
                    experience.DateOfFinish = null;
                }

                var addedExperince = new Experience
                {
                    CompanyName = experience.CompanyName,
                    DateOfFinish = experience.DateOfFinish,
                    DateOfStart = experience.DateOfStart,
                    Description = experience.Description,
                    Title = experience.Title,
                    EditDate=experience.EditDate,
                    IsDeleted = false,
                    Status = experience.Status
                };

                _context.Experiences.Add(addedExperince);
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