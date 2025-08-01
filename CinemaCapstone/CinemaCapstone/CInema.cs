using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class CInema
    {
        public string name;
        public List<Screen> screens;
        public List<Staff> Staff;
        public int regPrice;
        public int premPrice;
        public int popcornPrice;
        public CInema(string name, List<Screen> screens, List<Staff> staff, int regPrice, int premPrice, int popcornPrice)
        {
            this.name = name;
            this.Staff = staff;
            this.screens = screens;
            this.regPrice = regPrice;
            this.premPrice = premPrice;
            this.popcornPrice = popcornPrice;
        }


    }
}
