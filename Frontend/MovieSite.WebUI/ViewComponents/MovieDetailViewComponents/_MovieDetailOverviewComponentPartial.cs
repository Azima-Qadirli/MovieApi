using Microsoft.AspNetCore.Mvc;

namespace MovieSite.WebUI.ViewComponents.MovieDetailViewComponents
{
    public class _MovieDetailOverviewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
