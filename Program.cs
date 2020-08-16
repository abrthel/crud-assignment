using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudApp
{
    class Program
    {
        static void Main()
        {
            bool quit = false;
            List<string> emailAddresses = new List<string> {
                "aaron@live.ca", "marshal@live.ca", "tina@outlook.com", "shawna@live.ca", "justin@outlook.com", "marcus@gmail.com",
                "abby@msn.com", "jim@yahoo.com", "martin@live.ca", "fay@live.ca"
            };

            Console.WriteLine("Type an action name or 'help' for more information. 'q' to quit.");
            do
            {
                Console.WriteLine();
                string action = Console.ReadLine();
                try
                {
                    switch(action.Trim().ToLower())
                    {
                        case "list":
                            List(emailAddresses);
                            break;

                        case "add":

                            break;

                        case "edit":

                            break;

                        case "remove":

                            break;

                        case "quit":
                        case "q":
                            quit = true;
                            break;

                        case "help":
                        default:
                            // I'm aware this creates a new array on each call and I should
                            // avoid this. However, I'd say its a toy app and this looks cleaner
                            // to me.
                            Console.WriteLine(string.Join(Environment.NewLine, new string[] {
                                "list   - Lists all of the email addresses",
                                "add    - Adds a new email address",
                                "edit   - Updates an email address",
                                "remove - Removes an email address",
                                "quit   - Quits the program",
                                "help   - Displays this window",
                            }));
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: {0}\n", ex.Message);
                }
            } while(!quit);
        }

        static void List(List<string> emailAddresses)
        {

        }


    }
}
