using CoreCourse.RazorBasics.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreCourse.RazorBasics.Domain.Services
{
    public interface INewsArticleService
    {
        Task<IEnumerable<NewsArticle>> GetNewsArticles();
    }
}
