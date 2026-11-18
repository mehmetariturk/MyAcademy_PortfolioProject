using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultCertificationComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultCertificationComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Certifications.OrderByDescending(x => x.DateTime).ToList();
            return View(values);
        }
    }
}
