using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultWorkflowComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultWorkflowComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Workflows.OrderBy(x => x.StepOrder).ToList();
            return View(values);
        }
    }
}
