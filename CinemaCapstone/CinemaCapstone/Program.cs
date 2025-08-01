// See https://aka.ms/new-console-template for more information
using Capstone;
using Capstone.Menus;
using Capstone.parser;

Console.WriteLine("Hello, Capstone!");





string path = $@"{Environment.CurrentDirectory}\Resources\file1.txt";
CInema cinema = Parser.LoadCinema(path);
BuyMenu menu = new BuyMenu();
menu.CreateMenu();