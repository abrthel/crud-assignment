using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudApp
{
    class Program
    {
        /*
            Title: C# Introduction Assignment – CRUD
            Purpose: An application that accepts user supplied email address. The user can then List, Add, Edit & Delete the emails
                     in the list.

            Author: Aaron Barthel
            Last Modified: 08/16/2020
        */

        static void Main()
        {
            bool quit = false;
            List<string> emailAddresses = new List<string> {
                "aaron@live.ca", "marshal@live.ca", "tina@outlook.com", "shawna@live.ca", "justin@outlook.com", "marcus@gmail.com",
                "abby@msn.com", "jim@yahoo.com", "martin@live.ca", "fay@live.ca"
            };

            Console.WriteLine("Type an action name or 'help' for more information. 'q' to quit.\n\n");
            string action = GetAction();
            do
            {
                try
                {
                    switch(action)
                    {
                        case "list":
                            List(emailAddresses);
                            action = string.Empty;
                            break;

                        case "add":
                            action = string.Empty;
                            break;

                        case "edit":
                            action = string.Empty;
                            break;

                        case "remove":
                            action = string.Empty;
                            break;

                        case "clear":
                            action = string.Empty;
                            break;

                        case "quit":
                        case "q":
                            quit = true;
                            break;

                        case "help":
                            // I'm aware this creates a new array on each call and I should
                            // avoid this. However, I'd say its a toy app and this looks cleaner
                            // to me.
                            Console.WriteLine(string.Join(Environment.NewLine, new string[] {
                                "+====== Help Menu ======+",
                                "Select an action from the list below or type 'q' or 'quit' to quit the program.",
                                "list   - Lists all of the email addresses",
                                "add    - Adds a new email address",
                                "edit   - Updates an email address",
                                "remove - Removes an email address",
                                "clear  - Removes all email addresses",
                                "quit   - Quits the program",
                                "help   - Displays this window",
                            }));
                            action = string.Empty;
                            break;

                        default:
                            Console.WriteLine("Invalid action...\n");
                            action = "help";
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: {0}\n", ex.Message);
                }

                Console.Write("\n\n"); // Add space between outputs

                // Get next action from user if next menu is not
                // already set.
                if(string.IsNullOrEmpty(action))
                {
                    action = GetAction();
                }
            } while(!quit);
        }

        static string GetAction()
        {
            Console.Write("Select an action: ");
            return Console.ReadLine().ToLower().Trim();
        }
        /// <summary>
        /// Displays all of the email addresses in the console for the user to see.
        /// </summary>
        /// <param name="emailAddresses">List of email addresses to display.</param>
        static void List(List<string> emailAddresses)
        {
            Console.WriteLine("Email Addresses: ");
            int count = 1;
            foreach(string emailAddress in emailAddresses)
            {
                Console.WriteLine($"{count}. {emailAddress}");
                count++;
            }
        }


    }
}
