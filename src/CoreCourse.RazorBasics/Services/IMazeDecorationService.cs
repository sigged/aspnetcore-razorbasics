using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.RazorBasics.Services
{
    public interface IMazeDecorationService
    {
        string GetEmptyStyle();

        string GetFillStyle();
    }
}
