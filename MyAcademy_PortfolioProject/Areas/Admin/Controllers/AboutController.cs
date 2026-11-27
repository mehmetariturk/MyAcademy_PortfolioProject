using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;
using MyAcademy_PortfolioProject.Entities;

namespace MyAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly PortfolioContext _context;

        public AboutController(PortfolioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var value = _context.Abouts.FirstOrDefault() ?? new Entities.About();
            ViewBag.Highlights = _context.AboutHighlights.ToList();
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(About about, IFormFile? CvFile, List<AboutHighlight> Highlights)
        {
            if (CvFile != null)
            {
                var extension = Path.GetExtension(CvFile.FileName).ToLower();
                if (extension != ".pdf")
                {
                    ModelState.AddModelError("", "Only PDF files are allowed.");
                }
                else
                {
                    var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "cv");
                    Directory.CreateDirectory(folder);
                    var fileName = Guid.NewGuid() + extension;
                    using (var stream = new FileStream(Path.Combine(folder, fileName), FileMode.Create))
                    {
                        CvFile.CopyTo(stream);
                    }
                    about.CvUrl = "/cv/" + fileName;
                }
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Highlights = Highlights;
                return View(about);
            }

            if (about.AboutId == 0) _context.Abouts.Add(about);
            else _context.Abouts.Update(about);

            foreach (var item in Highlights)
            {
                var entity = _context.AboutHighlights.Find(item.AboutHighlightId);
                if (entity != null)
                {
                    entity.Title = item.Title;
                    entity.Description = item.Description;
                }
            }
            _context.SaveChanges();
            TempData["Success"] = "About saved successfully";
            return RedirectToAction("Index");
        }
    }
}
