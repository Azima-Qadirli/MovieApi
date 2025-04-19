using Microsoft.AspNetCore.Mvc;

namespace MovieSite.WebUI.ViewComponents.UserLayoutWebUIViewComponents
{
    public class _UserLayoutWebUIHeroComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
