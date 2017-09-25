using CoreCourse.RazorBasics.Domain.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace CoreCourse.RazorBasics.Controllers
{
    public class TagHelpersController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;

        public TagHelpersController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MethodWithParameters(int id, string filterText)
        {
            return Content($"The arguments for this method were: id={id} and filterText={filterText}");
        }

        public IActionResult SwapImage()
        {
            var webroot = _hostingEnvironment.WebRootPath;
            string redBirdPath = Path.Combine(webroot, "images", "angry-bird-red.png");
            string blueBirdPath = Path.Combine(webroot, "images", "angry-bird-blue.png");
            string currentBirdPath = Path.Combine(webroot, "images", "angry-bird-current.png");

            if (System.IO.File.Exists(redBirdPath)) //rename current to blue and red to current
            {
                System.IO.File.Move(currentBirdPath, blueBirdPath);
                System.IO.File.Move(redBirdPath, currentBirdPath);
            }
            else if (System.IO.File.Exists(blueBirdPath)) //rename current to red and blue to current
            {
                System.IO.File.Move(currentBirdPath, redBirdPath);
                System.IO.File.Move(blueBirdPath, currentBirdPath);
            }
            return RedirectToAction("Index");
        }


        public IActionResult RefreshOnly()
        {
            return RedirectToAction("Index");
        }

        public IActionResult RefreshAndChangeQuerystring()
        {
            //generate random string of 10 chars
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string result = new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return RedirectToAction("Index", new { changemetoexpire = result });
        }
    }
}