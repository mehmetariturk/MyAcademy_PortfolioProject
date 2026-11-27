using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyAcademy_PortfolioProject.Context;
using MyAcademy_PortfolioProject.Entities;
using static System.Net.WebRequestMethods;

namespace MyAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        private readonly PortfolioContext _context;

        public ProjectController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("ProjectList");
        }

        public IActionResult ProjectList()
        {
            var values = _context.Projects.Include(x => x.Category).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult CreateProject(Project project, IFormFile? CoverImage)
        {
            if (CoverImage != null)
            {
                var extension = Path.GetExtension(CoverImage.FileName).ToLower();
                var allowed = new[] { ".jpg", ".jpeg", ".png", ".webp" };

                if (!allowed.Contains(extension))
                {
                    ModelState.AddModelError("", "Only image files are allowed.");
                }
                else
                {
                    var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "projects");
                    Directory.CreateDirectory(folder);
                    var fileName = Guid.NewGuid() + extension;
                    using (var stream = new FileStream(Path.Combine(folder, fileName), FileMode.Create))
                    {
                        CoverImage.CopyTo(stream);
                    }
                    project.CoverImageUrl = "/images/projects/" + fileName;
                }
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_context.Categories.ToList(), "CategoryId", "CategoryName");
                return View(project);
            }

            _context.Projects.Add(project);
            _context.SaveChanges();
            TempData["Success"] = "Project added successfully";
            return RedirectToAction("ProjectList");
        }

        public IActionResult DeleteProject(int id)
        {
            var value = _context.Projects.Find(id);
            _context.Projects.Remove(value);
            _context.SaveChanges();
            TempData["Success"] = "Project deleted successfully";
            return RedirectToAction("ProjectList");
        }

        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "CategoryId", "CategoryName");
            var value = _context.Projects.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProject(Project project, IFormFile CoverImage)
        {
            if (CoverImage != null)
            {
                var extension = Path.GetExtension(CoverImage.FileName).ToLower();
                var allowed = new[] { ".jpg", ".jpeg", ".png", ".webp" };

                if (!allowed.Contains(extension))
                {
                    ModelState.AddModelError("", "Only image files are allowed.");
                }
                else
                {
                    var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "projects");
                    Directory.CreateDirectory(folder);
                    var fileName = Guid.NewGuid() + extension;
                    using (var stream = new FileStream(Path.Combine(folder, fileName), FileMode.Create))
                    {
                        CoverImage.CopyTo(stream);
                    }
                    project.CoverImageUrl = "/images/projects/" + fileName;
                }
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_context.Categories.ToList(), "CategoryId", "CategoryName");
                return View(project);
            }

            _context.Projects.Update(project);
            _context.SaveChanges();
            TempData["Success"] = "Project updated successfully";
            return RedirectToAction("ProjectList");
        }
    }
}
