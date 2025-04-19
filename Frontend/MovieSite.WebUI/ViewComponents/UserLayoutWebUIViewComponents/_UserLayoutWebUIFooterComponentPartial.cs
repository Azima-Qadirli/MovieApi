using Microsoft.AspNetCore.Mvc;

namespace MovieSite.WebUI.ViewComponents.UserLayoutWebUIViewComponents
{
    public class _UserLayoutWebUIFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
