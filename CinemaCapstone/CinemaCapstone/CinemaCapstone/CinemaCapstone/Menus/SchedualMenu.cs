namespace Capstone.Menus
{
    /// <summary>
    /// Represents an example console menu that inherits from <see cref="ConsoleMenu"/>.
    /// This menu allows users to add numbers to a running total stored in an instance of the ExampleSumObject business class.
    /// </summary>
    internal class SchedualMenu
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleConsoleMenu"/> class with a specified <see cref="ExampleSumObject"/>.
        /// </summary>
        /// <param name="sum">An instance of <see cref="ExampleSumObject"/> that maintains the running total.</param>
        public SchedualMenu()
        {
        }

        /// <summary>
        /// Creates the menu by adding menu items.
        /// </summary>
        public void CreateMenu()
        {
            var menuOptions = new List<(string Label, Action action)>
            {
                ("", buyTicket)

            };
            ConsoleHelper.RunMenu("Welcome", menuOptions);
        }

        /// <summary>
        /// Gets the text to be displayed for the console menu.
        /// </summary>
        /// <returns>A string representing the menu text and the current total sum.</returns>
        public string MenuText()
        {
            return "";
        }

        private void buyTicket()
        {

        }

    }
}
