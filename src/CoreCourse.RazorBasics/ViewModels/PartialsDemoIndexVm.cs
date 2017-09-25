using CoreCourse.RazorBasics.Domain.Entities;
using System.Collections.Generic;

namespace CoreCourse.RazorBasics.ViewModels
{
    public class PartialsDemoIndexVm
    {
        public IEnumerable<NewsArticle> NewsArticles { get; set; }
    }
}
