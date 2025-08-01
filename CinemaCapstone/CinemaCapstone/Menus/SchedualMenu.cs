namespace Capstone.Menus
{
   
    /// Represents an example console menu that inherits from <see cref="ConsoleMenu"/>.
    /// This menu allows users to add numbers to a running total stored in an instance of the ExampleSumObject business class.
   
    internal class SchedualMenu
    {

       
        /// Initializes a new instance of the <see cref="ExampleConsoleMenu"/> class with a specified <see cref="ExampleSumObject"/>.
        
        /// <param name="sum">An instance of <see cref="ExampleSumObject"/> that maintains the running total.</param>
        public SchedualMenu()
        {
        }

        
        /// Creates the menu by adding menu items.
      
        public void CreateMenu()
        {
            var menuOptions = new List<(string Label, Action action)>
            {
                ("", buyTicket)

            };
            ConsoleHelper.RunMenu("Welcome", menuOptions);
        }

       
        /// Gets the text to be displayed for the console menu.
       
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
