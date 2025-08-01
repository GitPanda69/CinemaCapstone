using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class Staff
    {
        public int ID;
        public string level;
        public string name;
        public string lName;

        public Staff (int ID, string level, string name, string lName)
        {
            this.ID = ID;
            this.level = level;
            this.name = name;
            this.lName = lName;
        }


    }
}
