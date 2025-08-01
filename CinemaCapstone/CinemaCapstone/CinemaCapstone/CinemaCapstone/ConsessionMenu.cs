using Capstone.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class ConsessionMenu
    {

        public ConsessionMenu() 
        {
        }

        public void CreateMenu()
        {
            var menuOptions = new List<(string Label, Action action)>
            {
                ("Popcorn £4",BuyConsession),
                ("Soda £2",BuyConsession)
                
            };
            ConsoleHelper.RunMenu("Welcome", menuOptions);
        }

      

        public string MenuText()
        {
            return "";
        }

        private void BuyConsession() 
        { 
            
        
        }


    }
}
