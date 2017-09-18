using Microsoft.AspNetCore.Mvc;

namespace CoreCourse.RazorBasics.Controllers
{
    public class LayoutExamplesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bravo()
        {
            return View();
        }

        public IActionResult Charlie()
        {
            return View();
        }
    }
}