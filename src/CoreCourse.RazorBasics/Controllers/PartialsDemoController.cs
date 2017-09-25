using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreCourse.RazorBasics.ViewModels;
using CoreCourse.RazorBasics.Domain.Services;

namespace CoreCourse.RazorBasics.Controllers
{
    public class PartialsDemoController : Controller
    {
        private INewsArticleService _newsArticleService;

        public PartialsDemoController(INewsArticleService newsArticleService)
        {
            _newsArticleService = newsArticleService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new PartialsDemoIndexVm();
            model.NewsArticles = await _newsArticleService.GetNewsArticles();


            return View(model);
        }
    }
}