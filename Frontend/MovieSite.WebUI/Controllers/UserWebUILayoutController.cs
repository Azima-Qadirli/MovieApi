using Microsoft.AspNetCore.Mvc;

namespace MovieSite.WebUI.Controllers
{
    public class UserWebUILayoutController : Controller
    {
        public IActionResult LayoutUI()
        {
            return View();
        }
    }
}
