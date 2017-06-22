using Microsoft.AspNetCore.Mvc.Razor;

namespace CoreCourse.RazorBasics.Mvc
{
    public abstract class MyRazorPage<TModel> :  RazorPage<TModel>
    {
        public string UserName;
    }
}
