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
                    // Add login logic here
                    break;
                case 2:
                    Console.WriteLine("Sign Up selected.");
                    SignUp();
                    // Add sign-up logic here
                    break;
                case 3:
                    Console.WriteLine("Exiting the application.");
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
            string username = "";

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
                string password = Console.ReadLine();
                Console.WriteLine("Please confirm your password:");
                string passwordConfirm = Console.ReadLine();

                if(!string.IsNullOrEmpty(password) && password == passwordConfirm)
                {
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

                }
                else
                {
                    Console.WriteLine("Password is invalid or does not match, please try again.");
                }
            }
            



        }
    }
}
