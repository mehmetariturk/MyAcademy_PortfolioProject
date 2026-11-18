using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;
using MyAcademy_PortfolioProject.Models.ViewModels;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultAboutComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = new AboutViewModel
            {
                About = _context.Abouts.FirstOrDefault(),
                Highlights = _context.AboutHighlights.ToList()
            };
            return View(model);
        }
    }
}
