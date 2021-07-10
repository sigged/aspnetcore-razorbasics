using Microsoft.AspNetCore.Mvc.Razor;

namespace CoreCourse.RazorBasics.Services
{
    public abstract class MyRazorPage<TModel> :  RazorPage<TModel>
    {
        public string UserName;
    }
}
