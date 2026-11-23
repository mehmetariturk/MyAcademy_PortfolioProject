using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;
using MyAcademy_PortfolioProject.Entities;

namespace MyAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EducationController : Controller
    {
        private readonly PortfolioContext _context;

        public EducationController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("EducationList");
        }

        public IActionResult EducationList()
        {
            var values = _context.Educations.OrderByDescending(x => x.StartDate).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View(education);
            }

            _context.Educations.Add(education);
            _context.SaveChanges();
            TempData["Success"] = "Education added successfully";
            return RedirectToAction("EducationList");
        }

        public IActionResult DeleteEducation(int id)
        {
            var value = _context.Educations.Find(id);
            if (value == null)
            {
                return RedirectToAction("EducationList");
            }
            _context.Educations.Remove(value);
            _context.SaveChanges();
            TempData["Success"] = "Education deleted successfully";
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var value = _context.Educations.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View(education);
            }

            _context.Educations.Update(education);
            _context.SaveChanges();
            TempData["Success"] = "Education updated successfully";
            return RedirectToAction("EducationList");
        }
    }
}
