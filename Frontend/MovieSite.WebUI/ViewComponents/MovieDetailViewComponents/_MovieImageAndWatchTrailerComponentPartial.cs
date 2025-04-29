using Microsoft.AspNetCore.Mvc;

namespace MovieSite.WebUI.ViewComponents.MovieDetailViewComponents
{
    public class _MovieImageAndWatchTrailerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
