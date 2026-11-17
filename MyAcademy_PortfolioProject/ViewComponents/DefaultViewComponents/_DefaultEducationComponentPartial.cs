using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultEducationComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultEducationComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Educations.Where(x => x.IsActive).OrderByDescending(x => x.StartDate).ToList();
            return View(values);
        }
    }
}
