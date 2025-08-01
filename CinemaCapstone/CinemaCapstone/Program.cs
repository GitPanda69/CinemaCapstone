// See https://aka.ms/new-console-template for more information
using Capstone;
using Capstone.Menus;
using Capstone.parser;

Console.WriteLine("Hello, Capstone!");

// To do list
// Link this repo to your github as it gives 5 marks
// Comment your code as it gives 5 marks
// Create a parser to read the file for the list of movies and showings (use chatgpt if need help and the format is on canvas)
// Create a class for the Movie, Showings and Concessions. Just see what they need to store e.g. movie needs a name, description.

// Make the 1st workflow as the minimum; select the showing, buy tickets, buy concessions and save it. I will show you snippets of my code as reference on how you want it to look.

string path = $@"{Environment.CurrentDirectory}\Resources\file1.txt";
CInema cinema = Parser.LoadCinema(path);
BuyMenu menu = new BuyMenu();
menu.CreateMenu();