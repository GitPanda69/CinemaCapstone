namespace Capstone.Menus
{
    /// <summary>
    /// Represents an example console menu that inherits from <see cref="ConsoleMenu"/>.
    /// This menu allows users to add numbers to a running total stored in an instance of the ExampleSumObject business class.
    /// </summary>
    internal class BuyTicketMenu
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleConsoleMenu"/> class with a specified <see cref="ExampleSumObject"/>.
        /// </summary>
        /// <param name="sum">An instance of <see cref="ExampleSumObject"/> that maintains the running total.</param>
        public BuyTicketMenu()
        {
        }

        /// <summary>
        /// Creates the menu by adding menu items.
        /// </summary>
        public void CreateMenu()
        {
            // Create a loop that goes through all the movies and then adds them to the menu below
            var menuOptions = new List<(string Label, Action action)>
            {
                ("boom", selecyMovie)

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

        // Change this so it has a movie as a parameter so we can select what movie the customer chooses
        private void selecyMovie()
        {
            
        }



    }
}
