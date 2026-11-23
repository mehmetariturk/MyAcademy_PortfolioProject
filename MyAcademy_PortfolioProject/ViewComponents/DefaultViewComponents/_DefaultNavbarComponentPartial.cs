using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultNavbarComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultNavbarComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value = _context.Abouts.FirstOrDefault();
            return View(value);
        }
    }
}
