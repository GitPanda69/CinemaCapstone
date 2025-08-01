using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class Screen
    {
        public int premiumSeats = 0;
        public int standardSeats = 0;
        public string name;

        public Screen(string name, int premiumSeats, int standardSeats) 
        { 
            this.premiumSeats = premiumSeats;
            this.standardSeats = standardSeats;
            this.name = name;
        }




    }
}
