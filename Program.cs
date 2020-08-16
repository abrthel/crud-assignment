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
                            Add(emailAddresses);
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

        /// <summary>
        /// Gets an action the user from the menu.
        /// </summary>
        /// <remarks>
        /// It is expected that the action returned from the user could be invalid. It is up to the
        /// menu to ensure invalid actions are handled gracefully.
        /// </remarks>
        /// <returns>The action collected from the user.</returns>
        static string GetAction()
        {
            Console.Write("Select an action: ");
            return Console.ReadLine().ToLower().Trim();
        }

        /// <summary>
        /// Gets a valid email address as input from the user.
        /// </summary>
        /// <param name="emailAddresses">List of email addresses to search for duplicate entries.</param>
        /// <returns>A valid email address from the user or string.empty when the user quits entering.</returns>
        static string GetEmailAddress(string message, List<string> emailAddresses)
        {
            string newEmailAddress;
            IList<string> validationMessages;
            bool done = false;
            do
            {
                Console.Write(message);
                newEmailAddress = Console.ReadLine();

                if(newEmailAddress == string.Empty)
                {
                    done = true;
                }
                else
                {
                    validationMessages = ValidateEmailAddress(newEmailAddress, emailAddresses);

                    if(validationMessages.Count > 0)
                    {
                        Console.WriteLine("Entered Email Address is invalid: ");
                        foreach(string errorMessage in validationMessages)
                        {
                            Console.WriteLine($"  - {errorMessage}");
                        }
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
            while(!done);
            return newEmailAddress;
        }

        /// <summary>
        /// Validates the given email address is a proper email address and that it's not a duplicated entry.
        /// </summary>
        /// <param name="emailAddress">The email add to validate</param>
        /// <param name="emailAddresses">List of addresses used to determine if the given address is a duplicate.</param>
        /// <returns>Returns a list of validation error messages if any are found.</returns>
        static IList<string> ValidateEmailAddress(string emailAddress, List<string> emailAddresses)
        {
            List<string> validationMessages = new List<string>();

            if(string.IsNullOrWhiteSpace(emailAddress))
            {
                validationMessages.Add("Email address cannot be empty or just whitespace.");
            }
            else if(emailAddresses.FindIndex(x => x.Equals(emailAddress, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                validationMessages.Add("Entered email address is a duplicate of one already in the database");
            }

            return validationMessages;
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

        /// <summary>
        /// Adds an email address to the list of email addresses.
        /// </summary>
        /// <param name="emailAddresses">List of email addresses</param>
        static void Add(List<string> emailAddresses)
        {
            string emailAddress;
            bool done = false;

            Console.WriteLine("Add new email addresses to the database. Press enter on an empty line when finshed.");
            do
            {
                emailAddress = GetEmailAddress("Enter a new email address: ", emailAddresses);

                if(string.IsNullOrEmpty(emailAddress))
                {
                    done = true;
                }
                else
                {
                    emailAddresses.Add(emailAddress);
                }

            } while(!done);
        }
    }
}
