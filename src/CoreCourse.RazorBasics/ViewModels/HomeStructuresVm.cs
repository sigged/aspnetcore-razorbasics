namespace CoreCourse.RazorBasics.ViewModels
{
    public class HomeStructuresVm
    {
        /// <summary>
        /// Holds the name of the player
        /// </summary>
        public string PlayerName { get; set; }

        /// <summary>
        /// Holds the values of the rolled dice
        /// </summary>
        public int[] DiceValues { get; set; }

        public int NumberOfDice { get; set; }
    }
}
