using Microsoft.AspNetCore.Mvc;

namespace MovieSite.WebUI.ViewComponents.UserLayoutWebUIViewComponents
{
    public class _UserLayoutWebUINavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
