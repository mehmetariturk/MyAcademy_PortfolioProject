using Microsoft.AspNetCore.Mvc;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
