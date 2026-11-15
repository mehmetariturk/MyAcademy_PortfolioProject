using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeroSectionComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultHeroSectionComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.HeroSections.FirstOrDefault();
            ViewBag.Title = values.Title;
            ViewBag.SubTitle = values.SubTitle;
            ViewBag.Description = values.Description;
            ViewBag.ImageUrl = values.ImageUrl;
            return View();
        }
    }
}
