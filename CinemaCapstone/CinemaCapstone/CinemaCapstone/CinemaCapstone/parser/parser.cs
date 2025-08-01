using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.parser
{
   
    static class Parser
    {
        public static string _location;


        public static CInema LoadCinema(string location)
        {
            string name = "";
            List<Screen> screens = new List<Screen>();
            List<Staff> staffs = new List<Staff>();
            int premPrice = 0;
            int regularPrice = 0;
            int popcornPrice = 0;

            foreach (var line in File.ReadLines(location))
            {
                if (line.StartsWith("[Name:"))
                {
                    name = line.Substring(6, line.Length - 7).Trim();
                }
                else if (line.StartsWith("[Screen"))
                {
                    string[] parts = line.Split('%');
                    Screen screen = new Screen(parts[0].Split(':')[1],
                    Convert.ToInt32(parts[1].Split(':')[1]),
                    Convert.ToInt32(parts[2].Split(':')[1].Split(']')[0]));
                    screens.Add(screen);
                }
                else if (line.StartsWith("[Staff"))
                {
                    string[] parts = line.Split('%');
                    Staff staff = new Staff(Convert.ToInt32(parts[0].Split(':')[1]),
                        parts[1].Split(':')[1],
                        parts[2].Split(':')[1],
                        parts[3].Split(':')[1].Split(']')[0]);
                        staffs.Add(staff);
                } 
                else if (line.StartsWith("[Ticket:Standard"))
                {

                    string[] parts = line.Split('%');
                    regularPrice = Convert.ToInt32(parts[1].Trim(']'));

                }
                else if (line.StartsWith("[Ticket:Premium"))
                {
                    string[] parts = line.Split('%');
                    premPrice = Convert.ToInt32(parts[1].Trim(']'));
                }
                else if (line.StartsWith("[Concession:Popcorn"))
                {
                    string[] parts = line.Split('%');
                    //popcornPrice = Convert.ToInt32(parts[1].Trim(']'));
                }

                
              
            }
            

            return new CInema(name, screens, staffs, regularPrice, premPrice,popcornPrice);
        }

        
        



    }

    
    

}
/// <summary>
/// Create another parser for loading in all the movies and showings in the cinema, the way you create it is similar to the Loadcinema
/// All you need to change is what syntax it expects from the format (check canvas)
/// </summary>