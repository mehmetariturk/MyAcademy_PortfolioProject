using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAcademy_PortfolioProject.Context;
using MyAcademy_PortfolioProject.Models.ViewModels;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultProjectComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultProjectComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        
        public IViewComponentResult Invoke()
        {

            var model = new ProjectViewModel
            {
                Projects = _context.Projects.Where(x => x.IsActive).Include(x => x.Category).Include(x => x.TechnicalSkills).ToList(),
                Categories = _context.Categories.ToList()
            };
            return View(model);
        }
    }
}
