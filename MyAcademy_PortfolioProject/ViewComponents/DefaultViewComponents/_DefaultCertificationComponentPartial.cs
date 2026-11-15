using Microsoft.AspNetCore.Mvc;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultCertificationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
