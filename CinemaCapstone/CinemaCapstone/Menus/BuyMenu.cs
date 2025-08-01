namespace Capstone.Menus
{
    /// <summary>
    /// Represents an example console menu that inherits from <see cref="ConsoleMenu"/>.
    /// This menu allows users to add numbers to a running total stored in an instance of the ExampleSumObject business class.
    /// </summary>
    internal class BuyMenu
    {
        private ExampleSumObject _totalSum;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleConsoleMenu"/> class with a specified <see cref="ExampleSumObject"/>.
        /// </summary>
        /// <param name="sum">An instance of <see cref="ExampleSumObject"/> that maintains the running total.</param>
        public BuyMenu()
        {
        }

        /// <summary>
        /// Creates the menu by adding menu items.
        /// </summary>
        public void CreateMenu()
        {

            // Creating a list of all options. 1st paremeter is the heading and 2nd is the function to run
            var menuOptions = new List<(string Label, Action action)>
            {
                ("Buy ticket", buyTicket),
                ("View Schedual", viewSchedual),
                ("Buy Conssesion", viewConsession),
                
            };
            ConsoleHelper.RunMenu("Welcome", menuOptions); // This runs the menu
        }

        /// <summary>
        /// Gets the text to be displayed for the console menu.
        /// </summary>
        /// <returns>A string representing the menu text and the current total sum.</returns>
        public string MenuText()
        {
            return $"Example Menu That Adds Numbers {Environment.NewLine}Total : {_totalSum}";
        }

        // Handling the buyTicket option, we are instantiating a new BuyTicketMenu and calling it
        private void buyTicket() 
        { 
            BuyTicketMenu buyTicketMenu = new BuyTicketMenu();
            buyTicketMenu.CreateMenu();
        }

        private void viewSchedual()
        { 
            SchedualMenu viewSchedualMenu = new SchedualMenu();
            viewSchedualMenu.CreateMenu();
        }

        private void viewConsession()
        {
            ConsessionMenu viewConsession = new ConsessionMenu();
            viewConsession.CreateMenu();
        }


    }
}
