using Microsoft.AspNetCore.Mvc;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultEducationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
