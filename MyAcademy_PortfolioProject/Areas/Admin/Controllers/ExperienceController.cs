using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;
using MyAcademy_PortfolioProject.Entities;
using System.ComponentModel.DataAnnotations;

namespace MyAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
    {
        private readonly PortfolioContext _context;

        public ExperienceController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("ExperienceList");
        }
        
        public IActionResult ExperienceList()
        {
            var values = _context.Experiences.OrderByDescending(x => x.StartDate).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                return View(experience);
            }
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            TempData["Success"] = "Experience added successfully";
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            _context.Experiences.Remove(value);
            _context.SaveChanges();
            TempData["Success"] = "Experience deleted successfully";
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            TempData["Success"] = "Experience updated successfully";
            return RedirectToAction("ExperienceList");
        }
    }
}
