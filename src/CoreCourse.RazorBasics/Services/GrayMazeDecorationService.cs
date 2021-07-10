using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.RazorBasics.Services
{
    public class GrayMazeDecorationService : IMazeDecorationService
    {        
        public string GetEmptyStyle()
        {
            return "width:10px;height:10px;background:transparent";
        }
        public string GetFillStyle()
        {
            return "width:10px;height:10px;background-color:#ccc";
        }
    }
}
