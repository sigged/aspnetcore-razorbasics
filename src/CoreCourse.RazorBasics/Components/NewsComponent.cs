using CoreCourse.RazorBasics.Domain.Entities;
using CoreCourse.RazorBasics.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.RazorBasics.Components
{
    [ViewComponent(Name = "NewsItems")]
    public class NewsComponent : ViewComponent
    {
        private INewsArticleService _newsArticleService;

        public NewsComponent(INewsArticleService newsArticleService)
        {
            _newsArticleService = newsArticleService;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool sortDescending, int? maxItems)
        {
            var articles = await _newsArticleService.GetNewsArticles(); 

            //order in requested direction
            if(sortDescending)
                articles = articles.OrderByDescending(e => e.CreationDate);
            else
                articles = articles.OrderBy(e => e.CreationDate);

            //limit # items if needed
            if (maxItems.HasValue)
                articles = articles.Take(maxItems.Value);
            
            return View(articles);
        }
    }
}
