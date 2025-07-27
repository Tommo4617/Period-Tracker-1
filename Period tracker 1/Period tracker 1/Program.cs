// See https://aka.ms/new-console-template for more information
using Period_tracker_1;

MenuMaker startupMenu = new Startup_Menu();
startupMenu.DisplayMenu();
startupMenu.ChoiceAction(int.Parse(Console.ReadLine()));
