using CoreCourse.RazorBasics.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace CoreCourse.RazorBasics.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expressions()
        {
            var vm = new HomeExpressionsVm
            {
                UserName = "siegfried",
                UserPrimaryMail = "siegfried@example.com",
                UserAllMail = new string[] { "siegfried@example.com", "sigge@com.example" },
                MaxAddresses = 10,
                MailDomain = "@example.com",
                HtmlContent = "<b onclick=\"alert('I got clicked!')\">HTML encoding is <i>safer</i>.</b>"
            };
            return View(vm);
        }

        public IActionResult Blocks()
        {
            return View();
        }

        public IActionResult Structures()
        {
            Random r = new Random();
            var vm = new HomeStructuresVm
            {
                PlayerName = "siegfried",
                DiceValues = new int[] { r.Next(6) + 1, r.Next(6) + 1 } //fill two dice with random values between 1 and 6 (inclusive)
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Structures(HomeStructuresVm structures)
        {
            Random r = new Random();
            structures.DiceValues = new int[structures.NumberOfDice];
            for (int dice = 0; dice < structures.NumberOfDice; dice++)
            {
                structures.DiceValues[dice] = r.Next(6) + 1;
            }
            return View(structures);
        }

        public IActionResult Directives()
        {
            Random r = new Random();
            HomeDirectivesVm viewmodel = new HomeDirectivesVm();
            //generate maze cells
            viewmodel.MazeCells = new bool[30, 30];
            for (int x = 0; x < viewmodel.MazeCells.GetUpperBound(0); x++)
            {
                for (int y = 0; y < viewmodel.MazeCells.GetUpperBound(1); y++)
                {
                    viewmodel.MazeCells[x, y] = r.Next(2) == 0;
                }
            }

            return View(viewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
