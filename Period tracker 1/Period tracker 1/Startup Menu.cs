using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Period_tracker_1
{
    internal class Startup_Menu : MenuMaker
    {

        public Startup_Menu() : base("Welcome to the period tracker!", ["Login", "Sign Up"]){

        

        }

        public override void ChoiceAction(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Login selected.");
                    login();
                    break;
                case 2:
                    Console.WriteLine("Sign Up selected.");
                    SignUp();

                    break;
                case 3:
                    Console.Write("Exiting");
                    for (int i=0; i < 3; i++)
                    { 
                        Thread.Sleep(500);
                        Console.Write(".");
                    }
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        private void SignUp()
        {
            bool validUsername = false;
            bool validPassword = false;
<<<<<<< Updated upstream
            string username = "";
=======
            bool validPStart = false;
            string username = "";
            string password = "";
            DateTime periodStart = DateTime.MinValue;
>>>>>>> Stashed changes

            while (!validUsername)
            {
                Console.WriteLine("Please enter your username:");
                username = Console.ReadLine();
                if (!string.IsNullOrEmpty(username))
                {
                    validUsername = true;
                }

                else
                {
                    Console.WriteLine("Username is invalid, please try again.");
                }
            }

            while (!validPassword)
            {
                Console.WriteLine("Please enter your password:");
                password = Console.ReadLine();
                Console.WriteLine("Please confirm your password:");
                string passwordConfirm = Console.ReadLine();

                if(!string.IsNullOrEmpty(password) && password == passwordConfirm)
                {
<<<<<<< Updated upstream
                    validPassword = true;
                    Console.WriteLine("Password confirmed, navigating back to the main menu.");
                    File.AppendAllText("loginList.txt", $"{username}:{password}\n");

                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(500);
                    }
                    Startup_Menu startup_Menu = new Startup_Menu();
                    startup_Menu.DisplayMenu();
                    startup_Menu.ChoiceAction(int.Parse(Console.ReadLine()));
=======
                    validPassword = true;    
>>>>>>> Stashed changes

                }
                else
                {
                    Console.WriteLine("Password is invalid or does not match, please try again.");
                }
            }
            while (!validPStart)
            {

                Console.WriteLine("PLease enter the start date if your last period (DD/MM/YYYY):");
                string periodStartInput = Console.ReadLine();
                try
                {
                    periodStart = DateTime.ParseExact(periodStartInput, "dd/MM/yyyy", null);
                    validPStart = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid date format. Please enter the date in DD/MM/YYYY format.");
                }

                File.AppendAllText("loginList.txt", $"{username}:{password}:{periodStart.ToString("dd/MM/yyyy")}\n");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(500);
                }
                Startup_Menu startup_Menu = new Startup_Menu();
                startup_Menu.DisplayMenu();
                startup_Menu.ChoiceAction(int.Parse(Console.ReadLine()));
            }
            



        }

        private void login()
        {
            bool matchFound = false;

            while (!matchFound)
            {
                Console.WriteLine("Please enter your username:");
                string username = Console.ReadLine();
                Console.WriteLine("Please enter your password:");
                string password = Console.ReadLine();
                string[] loginList = File.ReadAllLines("loginList.txt");
                foreach (string login in loginList)
                {
                    if(login.StartsWith(username + ":") && login.EndsWith(":" + password))
                    {
                        matchFound = true;
                        Console.WriteLine("Login successful! Welcome back, " + username + ".");
                        // Navigate to the main menu or dashboard
                        break;
                    }
                }
                if (!matchFound)
                {
                    Console.WriteLine("Login failed. Please check your username and password and try again.");
                }
            }
        }
    }
}
