namespace CoreCourse.RazorBasics.ViewModels
{
    public class HomeDirectivesVm
    {
        /// <summary>
        /// Holds the cell information in a 2 dimensional array of booleans
        /// </summary>
        /// <remarks>
        /// True = filled cell, False = empty cell
        /// </remarks>
        public bool[,] MazeCells { get; set; }
    }
}
