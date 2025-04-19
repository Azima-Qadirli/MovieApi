using Microsoft.AspNetCore.Mvc;

namespace MovieSite.WebUI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult MovieList()
        {
            ViewBag.v1 = "Movie List";
            ViewBag.v2 = "Home page";
            ViewBag.v3 = "All movies";
            return View();
        }
    }
}
